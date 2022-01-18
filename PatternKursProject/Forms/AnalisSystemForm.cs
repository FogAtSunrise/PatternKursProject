using PatternKursProject.commandPatt;
using PatternKursProject.devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternKursProject.Forms
{
    public partial class AnalisSystemForm : Form
    {
        private MonitoringSystem centreMonitor;
        private AnalysisSystemMethod activeSystem;
        public AnalisSystemForm(MonitoringSystem c, int s)
        {
            InitializeComponent();
            centreMonitor = c;
            activeSystem = centreMonitor.listAnalysisSystem[s];
            writeTable1();
            writeTable2();
        }

        /// <summary>
        /// заполнение таблицы систем анализа
        /// </summary>
        private void writeTable1()
        {
            dataGridView1.Rows.Clear();
            List<MeasuringDevice> list = activeSystem.getLastDev();
            if (list.Count > 0)
            {
                int count = list.Count;
                for (int i = 0; i < count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = list[i].getName();
                    string str = list[i].getName();
                    if (str == "Газоанализатор"|| str == "Водоанализатор"|| str == "Почвоанализатор") {
                      str = list[i].getNorma().ToString() + "; " +
                            list[i].getNorma().ToString() + "; " +
                            list[i].getNorma().ToString();
                       dataGridView1.Rows[i].Cells[1].Value = str; 
                }
                    else dataGridView1.Rows[i].Cells[1].Value = list[i].getNorma();
                    dataGridView1.Rows[i].Cells[2].Value = "Удалить";
                }
            }
        }


        /// <summary>
        /// заполнение таблицы измерений
        /// </summary>
        private void writeTable2()
        {
            List<Measurement> list = activeSystem.getLastMeasurements();
            if (list == null)
                list=activeSystem.getMeasurements();
            dataGridViewM.Rows.Clear();
            if (list.Count > 0)
            {
                int count = list.Count;
                for (int i = 0; i < count; i++)
                {
                    dataGridViewM.Rows.Add();
                    dataGridViewM.Rows[i].Cells[0].Value = list[i].nameMeasurement;
                    dataGridViewM.Rows[i].Cells[1].Value = list[i].meanMeasurement;
                    dataGridViewM.Rows[i].Cells[2].Value = list[i].unitMeasurement;
                    dataGridViewM.Rows[i].Cells[3].Value = list[i].deviationMeasurement;

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                
                case "del":
                    {

                        centreMonitor.setCommand(new CommandDelSystem(e.RowIndex));
                        centreMonitor.executeCommand();

                        writeTable2();

                        break;
                    }

            }
        }
    }
}
