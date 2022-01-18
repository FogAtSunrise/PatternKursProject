
using PatternKursProject.commandPatt;
using PatternKursProject.DecoratorAnalysisSystem;
using PatternKursProject.status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternKursProject
{
    public class MonitoringSystem
    {

        private State state;
        public void setState(State s)
        { state = s; }
        public string getState()
        { return state.getName(); }
        public State changeState()
        {
            state.make();
            return state;
        }
        /// <summary>
        /// команды
        /// </summary>
        private Command command;
        public void setCommand(Command c)
        { command = c; }
        public void executeCommand()
        { command.execute(); }
        /// <summary>
        /// объект системы (для Singleton)
        /// </summary>
        private static MonitoringSystem instance = null;

        /// <summary>
        /// приватный конструктор
        /// </summary>
        private MonitoringSystem() { 
            listAnalysisSystem = new List<AnalysisSystemMethod>();
            countAS = 0;
            state = new OffState();
        }
        /// <summary>
        /// количество систем анализа
        /// </summary>
        private int countAS;
        public int getCountAS() {
            countAS++;
            return countAS; }
        /// <summary>
        /// публичный конструткор
        /// <returns></returns>
        public static MonitoringSystem getInstance()
        {
            if (instance == null)
                instance = new MonitoringSystem();
           // else MessageBox.Show("Попытка создать новый центр управления отклонена.");
            return instance;
        }
        /// <summary>
        /// список систем анализа, установленных в системе мониторинга - совпадает с числом истоников
        /// </summary>
        public List<AnalysisSystemMethod> listAnalysisSystem;

        public void addAnalysisSystem(AnalysisSystemMethod t)
        { listAnalysisSystem.Add(t);
          MessageBox.Show("Система №"+ countAS + " успешно создана");
          
        }
        public void delAnalysisSystem(int t)
        {
            int h = listAnalysisSystem[t].getAccountNumber();
            listAnalysisSystem.RemoveAt(t);
          //  MessageBox.Show("Система №" + h + " успешно удалена");

        }
        public void getMeasurement()
        {
            if (listAnalysisSystem.Count > 0)
            {
                foreach (var syst in listAnalysisSystem)
                {
                    syst.getMeasurements();
                    AnalysisSystemWithReport f = new AnalysisSystemWithReport(syst);
                    f.writeInReport();
                }
            }
        }
    }
}
