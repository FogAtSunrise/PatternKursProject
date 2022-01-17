using Microsoft.TeamFoundation.WorkItemTracking.Client.Wiql;
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

namespace PatternKursProject
{
    public partial class MainWindow : Form
    {
        private MonitoringSystem centreMonitoring;
        private Button currentButton;
        private Form activeForm;
        public MainWindow()
        {
            InitializeComponent();
            centreMonitoring = MonitoringSystem.getInstance();
            label1.Text = "HOME";
            btnCloseChildForm.Visible = false;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                   
                    currentButton = (Button)btnSender;
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        /// <summary>
        /// заполнение таблицы систем анализа
        /// </summary>
        private void writeTable()
        {
            dataGridViewSA.Rows.Clear();
            if (centreMonitoring.listAnalysisSystem.Count > 0)
            {
                int count = centreMonitoring.listAnalysisSystem.Count;
                for (int i = 0; i < count; i++)
                {
                    dataGridViewSA.Rows.Add();
                    dataGridViewSA.Rows[i].Cells[0].Value = centreMonitoring.listAnalysisSystem[i].getAccountNumber();
                    dataGridViewSA.Rows[i].Cells[1].Value = centreMonitoring.listAnalysisSystem[i].getTypeOfSystem();
                    dataGridViewSA.Rows[i].Cells[2].Value = "Открыть";
                }
            }
        }

        
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelWorkZone.Controls.Add(childForm);
            this.panelWorkZone.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void buttonAddAS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddAS(centreMonitoring), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            label1.Text = "HOME";
            currentButton = null;
            btnCloseChildForm.Visible = false;
            writeTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCloseChildForm_Click(sender, e);
        }

    

        private void dataGridViewSA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridViewSA.Columns[e.ColumnIndex].Name)
            {
                case "open":
                    {
                        
                        OpenChildForm(new Forms.AnalisSystemForm(centreMonitoring, centreMonitoring.listAnalysisSystem[e.RowIndex]), new Button());
                      //  MessageBox.Show("Данные будут удалены безвозвратно. Вы уверены?", "Выбрана строка № " + e.RowIndex, MessageBoxButtons.OKCancel);
                        break;
                    }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddAS(centreMonitoring), sender);
        }
    }
}
