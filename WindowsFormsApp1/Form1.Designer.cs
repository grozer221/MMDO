﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewInputMatrix = new System.Windows.Forms.DataGridView();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRulesDescription = new System.Windows.Forms.Label();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaxTable = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinTable = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelRulesTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(335, 41);
            this.numericUpDownRows.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownRows.TabIndex = 1;
            this.numericUpDownRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.Location = new System.Drawing.Point(433, 41);
            this.numericUpDownColumns.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownColumns.TabIndex = 2;
            this.numericUpDownColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownColumns.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownColumns.ValueChanged += new System.EventHandler(this.numericUpDownColumns_ValueChanged);
            // 
            // dataGridViewInputMatrix
            // 
            this.dataGridViewInputMatrix.AllowUserToAddRows = false;
            this.dataGridViewInputMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewInputMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewInputMatrix.AllowUserToResizeRows = false;
            this.dataGridViewInputMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInputMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputMatrix.ColumnHeadersVisible = false;
            this.dataGridViewInputMatrix.Location = new System.Drawing.Point(7, 92);
            this.dataGridViewInputMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInputMatrix.MultiSelect = false;
            this.dataGridViewInputMatrix.Name = "dataGridViewInputMatrix";
            this.dataGridViewInputMatrix.RowHeadersVisible = false;
            this.dataGridViewInputMatrix.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewInputMatrix.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInputMatrix.RowTemplate.Height = 24;
            this.dataGridViewInputMatrix.Size = new System.Drawing.Size(503, 170);
            this.dataGridViewInputMatrix.TabIndex = 0;
            this.dataGridViewInputMatrix.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewInputMatrix_EditingControlShowing);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(7, 298);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(503, 31);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Розрахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "max",
            "min"});
            this.comboBoxType.Location = new System.Drawing.Point(14, 40);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(125, 21);
            this.comboBoxType.TabIndex = 3;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(332, 17);
            this.labelSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(178, 13);
            this.labelSize.TabIndex = 6;
            this.labelSize.Text = "Розміри вхідної симплекс-таблиці";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(11, 17);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(65, 13);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Тип функції";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageHelp);
            this.tabControlMain.Location = new System.Drawing.Point(3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(525, 490);
            this.tabControlMain.TabIndex = 10;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.labelSize);
            this.tabPageMain.Controls.Add(this.numericUpDownRows);
            this.tabPageMain.Controls.Add(this.numericUpDownColumns);
            this.tabPageMain.Controls.Add(this.labelType);
            this.tabPageMain.Controls.Add(this.dataGridViewInputMatrix);
            this.tabPageMain.Controls.Add(this.buttonCalculate);
            this.tabPageMain.Controls.Add(this.comboBoxType);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(517, 464);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Головна";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.label2);
            this.tabPageHelp.Controls.Add(this.labelRulesDescription);
            this.tabPageHelp.Controls.Add(this.pictureBoxMax);
            this.tabPageHelp.Controls.Add(this.pictureBoxMaxTable);
            this.tabPageHelp.Controls.Add(this.pictureBoxMinTable);
            this.tabPageHelp.Controls.Add(this.pictureBoxMin);
            this.tabPageHelp.Controls.Add(this.labelMin);
            this.tabPageHelp.Controls.Add(this.labelMax);
            this.tabPageHelp.Controls.Add(this.labelRulesTitle);
            this.tabPageHelp.Controls.Add(this.label1);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHelp.Size = new System.Drawing.Size(517, 464);
            this.tabPageHelp.TabIndex = 1;
            this.tabPageHelp.Text = "Допомога";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-373, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "знак ≤ для max і ≥ для min";
            // 
            // labelRulesDescription
            // 
            this.labelRulesDescription.AutoSize = true;
            this.labelRulesDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRulesDescription.Location = new System.Drawing.Point(20, 48);
            this.labelRulesDescription.Name = "labelRulesDescription";
            this.labelRulesDescription.Size = new System.Drawing.Size(487, 20);
            this.labelRulesDescription.TabIndex = 12;
            this.labelRulesDescription.Text = "Під час заповнення таблиці всі нерівності повинні мати ";
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Image = global::WindowsFormsApp1.Properties.Resources.max;
            this.pictureBoxMax.Location = new System.Drawing.Point(4, 151);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(250, 130);
            this.pictureBoxMax.TabIndex = 8;
            this.pictureBoxMax.TabStop = false;
            // 
            // pictureBoxMaxTable
            // 
            this.pictureBoxMaxTable.Image = global::WindowsFormsApp1.Properties.Resources.maxTable;
            this.pictureBoxMaxTable.Location = new System.Drawing.Point(33, 287);
            this.pictureBoxMaxTable.Name = "pictureBoxMaxTable";
            this.pictureBoxMaxTable.Size = new System.Drawing.Size(190, 135);
            this.pictureBoxMaxTable.TabIndex = 9;
            this.pictureBoxMaxTable.TabStop = false;
            // 
            // pictureBoxMinTable
            // 
            this.pictureBoxMinTable.Image = global::WindowsFormsApp1.Properties.Resources.minTable;
            this.pictureBoxMinTable.Location = new System.Drawing.Point(300, 287);
            this.pictureBoxMinTable.Name = "pictureBoxMinTable";
            this.pictureBoxMinTable.Size = new System.Drawing.Size(190, 135);
            this.pictureBoxMinTable.TabIndex = 10;
            this.pictureBoxMinTable.TabStop = false;
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Image = global::WindowsFormsApp1.Properties.Resources.min;
            this.pictureBoxMin.Location = new System.Drawing.Point(267, 151);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(250, 130);
            this.pictureBoxMin.TabIndex = 11;
            this.pictureBoxMin.TabStop = false;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMin.Location = new System.Drawing.Point(313, 119);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(155, 20);
            this.labelMin.TabIndex = 6;
            this.labelMin.Text = "Приклад для min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax.Location = new System.Drawing.Point(48, 119);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(159, 20);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Приклад для max";
            // 
            // labelRulesTitle
            // 
            this.labelRulesTitle.AutoSize = true;
            this.labelRulesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRulesTitle.Location = new System.Drawing.Point(93, 3);
            this.labelRulesTitle.Name = "labelRulesTitle";
            this.labelRulesTitle.Size = new System.Drawing.Size(330, 31);
            this.labelRulesTitle.TabIndex = 5;
            this.labelRulesTitle.Text = "Правила введення даних";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 495);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Метод симплекс-таблиць";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageHelp.ResumeLayout(false);
            this.tabPageHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.DataGridView dataGridViewInputMatrix;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRulesDescription;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBoxMaxTable;
        private System.Windows.Forms.PictureBox pictureBoxMinTable;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelRulesTitle;
    }
}

