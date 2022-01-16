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
        private AnalysisSystem activeSystem;
        public AnalisSystemForm(MonitoringSystem c, AnalysisSystem s)
        {
            InitializeComponent();
            centreMonitor = c;
            activeSystem = s;
            writeTable1();
            activeSystem.getMeasurements();
            writeTable2();
        }

        /// <summary>
        /// заполнение таблицы систем анализа
        /// </summary>
        private void writeTable1()
        {
            dataGridView1.Rows.Clear();
            if (activeSystem.listDevices.Count > 0)
            {
                int count = activeSystem.listDevices.Count;
                for (int i = 0; i < count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = activeSystem.listDevices[i].getName();
                    dataGridView1.Rows[i].Cells[1].Value = activeSystem.listDevices[i].getNorma();
            
                }
            }
        }


        /// <summary>
        /// заполнение таблицы измерений
        /// </summary>
        private void writeTable2()
        {
            dataGridViewM.Rows.Clear();
            if (activeSystem.listLastMeasur.Count > 0)
            {
                int count = activeSystem.listLastMeasur.Count;
                for (int i = 0; i < count; i++)
                {
                    dataGridViewM.Rows.Add();
                    dataGridViewM.Rows[i].Cells[0].Value = activeSystem.listLastMeasur[i].nameMeasurement;
                    dataGridViewM.Rows[i].Cells[1].Value = activeSystem.listLastMeasur[i].meanMeasurement;
                    dataGridViewM.Rows[i].Cells[2].Value = activeSystem.listLastMeasur[i].unitMeasurement;
                    dataGridViewM.Rows[i].Cells[3].Value = activeSystem.listLastMeasur[i].deviationMeasurement;

                }
            }
        }
    }
}
