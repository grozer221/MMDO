namespace WindowsFormsApp1
{
    partial class Result
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
            this.labelResultF = new System.Windows.Forms.Label();
            this.tabControlTables = new System.Windows.Forms.TabControl();
            this.labelCalculations = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRulesDescription = new System.Windows.Forms.Label();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaxTable = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinTable = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelRulesTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResultF
            // 
            this.labelResultF.AutoSize = true;
            this.labelResultF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultF.Location = new System.Drawing.Point(18, 279);
            this.labelResultF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultF.Name = "labelResultF";
            this.labelResultF.Size = new System.Drawing.Size(0, 24);
            this.labelResultF.TabIndex = 4;
            // 
            // tabControlTables
            // 
            this.tabControlTables.Location = new System.Drawing.Point(9, 57);
            this.tabControlTables.Name = "tabControlTables";
            this.tabControlTables.SelectedIndex = 0;
            this.tabControlTables.Size = new System.Drawing.Size(475, 186);
            this.tabControlTables.TabIndex = 8;
            // 
            // labelCalculations
            // 
            this.labelCalculations.AutoSize = true;
            this.labelCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalculations.Location = new System.Drawing.Point(80, 16);
            this.labelCalculations.Name = "labelCalculations";
            this.labelCalculations.Size = new System.Drawing.Size(114, 24);
            this.labelCalculations.TabIndex = 9;
            this.labelCalculations.Text = "Розрахунки";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageHelp);
            this.tabControlMain.Location = new System.Drawing.Point(3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(521, 541);
            this.tabControlMain.TabIndex = 10;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.labelResultF);
            this.tabPageMain.Controls.Add(this.labelCalculations);
            this.tabPageMain.Controls.Add(this.tabControlTables);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(909, 515);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Головна";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.label2);
            this.tabPageHelp.Controls.Add(this.label1);
            this.tabPageHelp.Controls.Add(this.labelRulesDescription);
            this.tabPageHelp.Controls.Add(this.pictureBoxMax);
            this.tabPageHelp.Controls.Add(this.pictureBoxMaxTable);
            this.tabPageHelp.Controls.Add(this.pictureBoxMinTable);
            this.tabPageHelp.Controls.Add(this.pictureBoxMin);
            this.tabPageHelp.Controls.Add(this.labelMin);
            this.tabPageHelp.Controls.Add(this.labelMax);
            this.tabPageHelp.Controls.Add(this.labelRulesTitle);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHelp.Size = new System.Drawing.Size(513, 515);
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
            // labelRulesDescription
            // 
            this.labelRulesDescription.AutoSize = true;
            this.labelRulesDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRulesDescription.Location = new System.Drawing.Point(16, 62);
            this.labelRulesDescription.Name = "labelRulesDescription";
            this.labelRulesDescription.Size = new System.Drawing.Size(487, 20);
            this.labelRulesDescription.TabIndex = 3;
            this.labelRulesDescription.Text = "Під час заповнення таблиці всі нерівності повинні мати ";
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Image = global::WindowsFormsApp1.Properties.Resources.max;
            this.pictureBoxMax.Location = new System.Drawing.Point(0, 165);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(250, 130);
            this.pictureBoxMax.TabIndex = 2;
            this.pictureBoxMax.TabStop = false;
            // 
            // pictureBoxMaxTable
            // 
            this.pictureBoxMaxTable.Image = global::WindowsFormsApp1.Properties.Resources.maxTable;
            this.pictureBoxMaxTable.Location = new System.Drawing.Point(29, 301);
            this.pictureBoxMaxTable.Name = "pictureBoxMaxTable";
            this.pictureBoxMaxTable.Size = new System.Drawing.Size(190, 135);
            this.pictureBoxMaxTable.TabIndex = 2;
            this.pictureBoxMaxTable.TabStop = false;
            // 
            // pictureBoxMinTable
            // 
            this.pictureBoxMinTable.Image = global::WindowsFormsApp1.Properties.Resources.minTable;
            this.pictureBoxMinTable.Location = new System.Drawing.Point(296, 301);
            this.pictureBoxMinTable.Name = "pictureBoxMinTable";
            this.pictureBoxMinTable.Size = new System.Drawing.Size(190, 135);
            this.pictureBoxMinTable.TabIndex = 2;
            this.pictureBoxMinTable.TabStop = false;
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Image = global::WindowsFormsApp1.Properties.Resources.min;
            this.pictureBoxMin.Location = new System.Drawing.Point(263, 165);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(250, 130);
            this.pictureBoxMin.TabIndex = 2;
            this.pictureBoxMin.TabStop = false;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMin.Location = new System.Drawing.Point(309, 133);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(155, 20);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "Приклад для min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMax.Location = new System.Drawing.Point(44, 133);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(159, 20);
            this.labelMax.TabIndex = 1;
            this.labelMax.Text = "Приклад для max";
            // 
            // labelRulesTitle
            // 
            this.labelRulesTitle.AutoSize = true;
            this.labelRulesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRulesTitle.Location = new System.Drawing.Point(89, 17);
            this.labelRulesTitle.Name = "labelRulesTitle";
            this.labelRulesTitle.Size = new System.Drawing.Size(330, 31);
            this.labelRulesTitle.TabIndex = 0;
            this.labelRulesTitle.Text = "Правила введення даних";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "знак ≤ для max і ≥ для min";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 555);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Метод симплекс-таблиць";
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
        private System.Windows.Forms.Label labelResultF;
        private System.Windows.Forms.TabControl tabControlTables;
        private System.Windows.Forms.Label labelCalculations;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelRulesTitle;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelRulesDescription;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxMinTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBoxMaxTable;
        private System.Windows.Forms.Label label2;
    }
}

