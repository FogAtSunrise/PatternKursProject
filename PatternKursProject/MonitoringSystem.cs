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
        /// <summary>
        /// объект системы (для Singleton)
        /// </summary>
        private static MonitoringSystem instance = null;

        /// <summary>
        /// приватный конструктор
        /// </summary>
        private MonitoringSystem() { listAnalysisSystem = new List<AnalysisSystem>();
            countAS = 0;
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
            else MessageBox.Show("Попытка создать новый центр управления отклонена.");
            return instance;
        }
        /// <summary>
        /// список систем анализа, установленных в системе мониторинга - совпадает с числом истоников
        /// </summary>
        public List<AnalysisSystem> listAnalysisSystem;

        public void addAnalysisSystem(AnalysisSystem t)
        { listAnalysisSystem.Add(t);
          MessageBox.Show("Система №"+ countAS + " успешно создана");
          
        }
    }
}
