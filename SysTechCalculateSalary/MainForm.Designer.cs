namespace SysTechCalculateSalary
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabAddEmployee = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCalculateSalary = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbBaseRate = new System.Windows.Forms.TextBox();
            this.lblBaseRate = new System.Windows.Forms.Label();
            this.cmbBosses = new System.Windows.Forms.ComboBox();
            this.lblBoss = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.datePickerDateStart = new System.Windows.Forms.DateTimePicker();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabAddEmployee.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAddEmployee
            // 
            this.tabAddEmployee.Controls.Add(this.tabPage1);
            this.tabAddEmployee.Controls.Add(this.tabPage2);
            this.tabAddEmployee.Location = new System.Drawing.Point(52, 34);
            this.tabAddEmployee.Name = "tabAddEmployee";
            this.tabAddEmployee.SelectedIndex = 0;
            this.tabAddEmployee.Size = new System.Drawing.Size(796, 459);
            this.tabAddEmployee.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.btnCalculateSalary);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчет зарплаты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(417, 362);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Итого:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите дату для расчета";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.Location = new System.Drawing.Point(452, 24);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(123, 26);
            this.btnCalculateSalary.TabIndex = 1;
            this.btnCalculateSalary.Text = "Расчитать зарплату";
            this.btnCalculateSalary.UseVisualStyleBackColor = true;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbBaseRate);
            this.tabPage2.Controls.Add(this.lblBaseRate);
            this.tabPage2.Controls.Add(this.cmbBosses);
            this.tabPage2.Controls.Add(this.lblBoss);
            this.tabPage2.Controls.Add(this.cmbGroup);
            this.tabPage2.Controls.Add(this.lblGroup);
            this.tabPage2.Controls.Add(this.datePickerDateStart);
            this.tabPage2.Controls.Add(this.lblDateStart);
            this.tabPage2.Controls.Add(this.tbName);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление сотрудника";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbBaseRate
            // 
            this.tbBaseRate.Location = new System.Drawing.Point(137, 204);
            this.tbBaseRate.Name = "tbBaseRate";
            this.tbBaseRate.Size = new System.Drawing.Size(152, 20);
            this.tbBaseRate.TabIndex = 10;
            // 
            // lblBaseRate
            // 
            this.lblBaseRate.AutoSize = true;
            this.lblBaseRate.Location = new System.Drawing.Point(34, 207);
            this.lblBaseRate.Name = "lblBaseRate";
            this.lblBaseRate.Size = new System.Drawing.Size(88, 13);
            this.lblBaseRate.TabIndex = 9;
            this.lblBaseRate.Text = "Базовая ставка";
            // 
            // cmbBosses
            // 
            this.cmbBosses.FormattingEnabled = true;
            this.cmbBosses.Location = new System.Drawing.Point(137, 162);
            this.cmbBosses.Name = "cmbBosses";
            this.cmbBosses.Size = new System.Drawing.Size(152, 21);
            this.cmbBosses.TabIndex = 8;
            // 
            // lblBoss
            // 
            this.lblBoss.AutoSize = true;
            this.lblBoss.Location = new System.Drawing.Point(34, 170);
            this.lblBoss.Name = "lblBoss";
            this.lblBoss.Size = new System.Drawing.Size(62, 13);
            this.lblBoss.TabIndex = 7;
            this.lblBoss.Text = "Начальник";
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "Salesman"});
            this.cmbGroup.Location = new System.Drawing.Point(137, 123);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(152, 21);
            this.cmbGroup.TabIndex = 6;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(34, 126);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(42, 13);
            this.lblGroup.TabIndex = 5;
            this.lblGroup.Text = "Группа";
            // 
            // datePickerDateStart
            // 
            this.datePickerDateStart.Location = new System.Drawing.Point(137, 84);
            this.datePickerDateStart.Name = "datePickerDateStart";
            this.datePickerDateStart.Size = new System.Drawing.Size(200, 20);
            this.datePickerDateStart.TabIndex = 4;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(34, 84);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(77, 13);
            this.lblDateStart.TabIndex = 3;
            this.lblDateStart.Text = "Дата прихода";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(137, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Имя";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(331, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 537);
            this.Controls.Add(this.tabAddEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Системные технологии - HR";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabAddEmployee.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAddEmployee;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCalculateSalary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBaseRate;
        private System.Windows.Forms.ComboBox cmbBosses;
        private System.Windows.Forms.Label lblBoss;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.DateTimePicker datePickerDateStart;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.TextBox tbBaseRate;
        private System.Windows.Forms.Label lblTotal;
    }
}

