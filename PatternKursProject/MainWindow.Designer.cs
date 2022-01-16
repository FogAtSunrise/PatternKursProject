
namespace PatternKursProject
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddAS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelWorkZone = new System.Windows.Forms.Panel();
            this.dataGridViewSA = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelWorkZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.buttonAddAS);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 527);
            this.panelMenu.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAddAS
            // 
            this.buttonAddAS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAddAS.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddAS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddAS.Location = new System.Drawing.Point(0, 119);
            this.buttonAddAS.Name = "buttonAddAS";
            this.buttonAddAS.Size = new System.Drawing.Size(200, 53);
            this.buttonAddAS.TabIndex = 2;
            this.buttonAddAS.Text = "Добавить систему анализа";
            this.buttonAddAS.UseVisualStyleBackColor = false;
            this.buttonAddAS.Click += new System.EventHandler(this.buttonAddAS_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 66);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "       Центр\r\nмониторинга";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnCloseChildForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 66);
            this.panel1.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCloseChildForm.BackgroundImage = global::PatternKursProject.Properties.Resources._4115230_cancel_close_cross_delete_114048__2_;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(69, 66);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panelWorkZone
            // 
            this.panelWorkZone.Controls.Add(this.button3);
            this.panelWorkZone.Controls.Add(this.label3);
            this.panelWorkZone.Controls.Add(this.dataGridViewSA);
            this.panelWorkZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkZone.Location = new System.Drawing.Point(200, 66);
            this.panelWorkZone.Name = "panelWorkZone";
            this.panelWorkZone.Size = new System.Drawing.Size(815, 461);
            this.panelWorkZone.TabIndex = 2;
            // 
            // dataGridViewSA
            // 
            this.dataGridViewSA.AllowUserToAddRows = false;
            this.dataGridViewSA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.type,
            this.open});
            this.dataGridViewSA.Location = new System.Drawing.Point(393, 38);
            this.dataGridViewSA.Name = "dataGridViewSA";
            this.dataGridViewSA.ReadOnly = true;
            this.dataGridViewSA.RowHeadersVisible = false;
            this.dataGridViewSA.RowHeadersWidth = 51;
            this.dataGridViewSA.RowTemplate.Height = 24;
            this.dataGridViewSA.Size = new System.Drawing.Size(397, 355);
            this.dataGridViewSA.TabIndex = 0;
            this.dataGridViewSA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSA_CellContentClick);
            // 
            // num
            // 
            this.num.HeaderText = "№ системы";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // open
            // 
            this.open.HeaderText = "Открыть";
            this.open.MinimumWidth = 6;
            this.open.Name = "open";
            this.open.ReadOnly = true;
            this.open.Text = "Открыть";
            this.open.ToolTipText = "Открыть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Системы анализа на источниках";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить систему";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 527);
            this.Controls.Add(this.panelWorkZone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainWindow";
            this.Text = "Центр мониторинга";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWorkZone.ResumeLayout(false);
            this.panelWorkZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAddAS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelWorkZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewButtonColumn open;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}

