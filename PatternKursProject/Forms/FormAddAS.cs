using PatternKursProject.devices;
using PatternKursProject.sampleAnalyzer;
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
    public partial class FormAddAS : Form
    {
        private MonitoringSystem centreMonitor;

        public FormAddAS(MonitoringSystem c)
        {
            InitializeComponent();
            centreMonitor = c;
        }
        /// <summary>
        /// создаю систему анализа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        { 
            SourceType t;
            switch (comboBoxType.Text)
            { 
                case "AIR": t = SourceType.AIR; break;
                case "WATER": t = SourceType.WATER; break;
                case "SOIL": t = SourceType.SOIL; break;
                default: MessageBox.Show("Не указан тип системы"); return; 
            }
            AnalysisSystemMethod newSys = new AnalysisSystem(centreMonitor.getCountAS(), t);

            if (checkedListBox1.GetItemChecked(0))
                newSys.addDevice(new Thermometer(20));

            if (checkedListBox1.GetItemChecked(1))
                newSys.addDevice(new Barometer(760));
   
            if (checkedListBox1.GetItemChecked(2))
                newSys.addDevice(new Psychrometer(40));

            if (checkedListBox1.GetItemChecked(3))
                newSys.addDevice(new Anemometer(1.5));

            if (checkedListBox1.GetItemChecked(4))
                newSys.addDevice(new Diffmanometer(3.5));
            if (checkedListBox2.GetItemChecked(0))
                newSys.addDevice(new Adapter(new AirSampleAnalysis()));
            if (checkedListBox2.GetItemChecked(1))
                newSys.addDevice(new Adapter(new WaterSampleAnalysis()));
            if (checkedListBox2.GetItemChecked(2))
                newSys.addDevice(new Adapter(new SoilSampleAnalysis()));

            centreMonitor.addAnalysisSystem(newSys);
        }
    }
}
