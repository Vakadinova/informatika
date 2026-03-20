namespace ocenki_na_uchenici
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGrades = new System.Windows.Forms.TextBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.bAverage = new System.Windows.Forms.Button();
            this.bCount = new System.Windows.Forms.Button();
            this.bMin = new System.Windows.Forms.Button();
            this.bMax = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведете  10 оценки, разделени със запетая";
            // 
            // textBoxGrades
            // 
            this.textBoxGrades.Location = new System.Drawing.Point(49, 146);
            this.textBoxGrades.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxGrades.Name = "textBoxGrades";
            this.textBoxGrades.Size = new System.Drawing.Size(377, 31);
            this.textBoxGrades.TabIndex = 1;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 25;
            this.listBoxStudents.Location = new System.Drawing.Point(52, 210);
            this.listBoxStudents.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(374, 229);
            this.listBoxStudents.TabIndex = 2;
            // 
            // bAverage
            // 
            this.bAverage.AutoEllipsis = true;
            this.bAverage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bAverage.BackColor = System.Drawing.Color.Teal;
            this.bAverage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAverage.Location = new System.Drawing.Point(612, 81);
            this.bAverage.Margin = new System.Windows.Forms.Padding(6);
            this.bAverage.Name = "bAverage";
            this.bAverage.Size = new System.Drawing.Size(342, 44);
            this.bAverage.TabIndex = 3;
            this.bAverage.Text = "Среден успех";
            this.bAverage.UseVisualStyleBackColor = false;
            this.bAverage.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCount
            // 
            this.bCount.AutoEllipsis = true;
            this.bCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bCount.BackColor = System.Drawing.Color.Teal;
            this.bCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCount.Location = new System.Drawing.Point(612, 165);
            this.bCount.Margin = new System.Windows.Forms.Padding(6);
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(342, 44);
            this.bCount.TabIndex = 4;
            this.bCount.Text = "Общ брой оценки";
            this.bCount.UseVisualStyleBackColor = false;
            this.bCount.Click += new System.EventHandler(this.button2_Click);
            // 
            // bMin
            // 
            this.bMin.AutoEllipsis = true;
            this.bMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bMin.BackColor = System.Drawing.Color.Teal;
            this.bMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMin.Location = new System.Drawing.Point(612, 239);
            this.bMin.Margin = new System.Windows.Forms.Padding(6);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(342, 44);
            this.bMin.TabIndex = 5;
            this.bMin.Text = "Ученик с най - нисък успех";
            this.bMin.UseVisualStyleBackColor = false;
            this.bMin.Click += new System.EventHandler(this.button3_Click);
            // 
            // bMax
            // 
            this.bMax.AutoEllipsis = true;
            this.bMax.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bMax.BackColor = System.Drawing.Color.Teal;
            this.bMax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMax.Location = new System.Drawing.Point(612, 311);
            this.bMax.Margin = new System.Windows.Forms.Padding(6);
            this.bMax.Name = "bMax";
            this.bMax.Size = new System.Drawing.Size(351, 44);
            this.bMax.TabIndex = 6;
            this.bMax.Text = "Ученик с най- висок успех";
            this.bMax.UseVisualStyleBackColor = false;
            this.bMax.Click += new System.EventHandler(this.button4_Click);
            // 
            // bClear
            // 
            this.bClear.AutoEllipsis = true;
            this.bClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bClear.BackColor = System.Drawing.Color.Teal;
            this.bClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bClear.Location = new System.Drawing.Point(693, 435);
            this.bClear.Margin = new System.Windows.Forms.Padding(6);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(162, 44);
            this.bClear.TabIndex = 7;
            this.bClear.Text = "Изчисти";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.Green;
            this.labelResult.Location = new System.Drawing.Point(56, 518);
            this.labelResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(66, 24);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Изберете ученик";
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Items.AddRange(new object[] {
            "Иван",
            "Мария",
            "Елена",
            "Йордан"});
            this.comboBoxStudents.Location = new System.Drawing.Point(272, 22);
            this.comboBoxStudents.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(258, 33);
            this.comboBoxStudents.TabIndex = 11;
            this.comboBoxStudents.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudents_SelectedIndexChanged);
            // 
            // bAdd
            // 
            this.bAdd.AutoEllipsis = true;
            this.bAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAdd.Location = new System.Drawing.Point(693, 19);
            this.bAdd.Margin = new System.Windows.Forms.Padding(6);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(162, 44);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "Добави";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1033, 603);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bMax);
            this.Controls.Add(this.bMin);
            this.Controls.Add(this.bCount);
            this.Controls.Add(this.bAverage);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.textBoxGrades);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGrades;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Button bAverage;
        private System.Windows.Forms.Button bCount;
        private System.Windows.Forms.Button bMin;
        private System.Windows.Forms.Button bMax;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.Button bAdd;
    }
}

