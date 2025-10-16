namespace LinqLabs.HW
{
    partial class FrmHW3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAllRandom = new System.Windows.Forms.Button();
            this.btnRandom3Group = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClassScore = new System.Windows.Forms.Button();
            this.btnStudentScore = new System.Windows.Forms.Button();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllRandom
            // 
            this.btnAllRandom.Location = new System.Drawing.Point(53, 461);
            this.btnAllRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllRandom.Name = "btnAllRandom";
            this.btnAllRandom.Size = new System.Drawing.Size(273, 46);
            this.btnAllRandom.TabIndex = 157;
            this.btnAllRandom.Text = "所有隨機分數出現的次數/比率";
            this.btnAllRandom.UseVisualStyleBackColor = false;
            // 
            // btnRandom3Group
            // 
            this.btnRandom3Group.Location = new System.Drawing.Point(53, 407);
            this.btnRandom3Group.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom3Group.Name = "btnRandom3Group";
            this.btnRandom3Group.Size = new System.Drawing.Size(273, 46);
            this.btnRandom3Group.TabIndex = 156;
            this.btnRandom3Group.Text = "隨機 統計 100 個學生 分數 分成 三群";
            this.btnRandom3Group.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(423, 84);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(613, 423);
            this.chart1.TabIndex = 155;
            this.chart1.Text = "chart1";
            // 
            // btnClassScore
            // 
            this.btnClassScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClassScore.Location = new System.Drawing.Point(53, 84);
            this.btnClassScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnClassScore.Name = "btnClassScore";
            this.btnClassScore.Size = new System.Drawing.Size(273, 53);
            this.btnClassScore.TabIndex = 154;
            this.btnClassScore.Text = "搜尋 班級學生成績";
            this.btnClassScore.UseVisualStyleBackColor = false;
            this.btnClassScore.Click += new System.EventHandler(this.btnClassScore_Click);
            // 
            // btnStudentScore
            // 
            this.btnStudentScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStudentScore.Location = new System.Drawing.Point(53, 218);
            this.btnStudentScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentScore.Name = "btnStudentScore";
            this.btnStudentScore.Size = new System.Drawing.Size(273, 53);
            this.btnStudentScore.TabIndex = 153;
            this.btnStudentScore.Text = "每個學生個人成績";
            this.btnStudentScore.UseVisualStyleBackColor = false;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(53, 40);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 25);
            this.comboBoxClass.TabIndex = 158;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(53, 174);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(121, 25);
            this.comboBoxStudent.TabIndex = 158;
            // 
            // FrmHW3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 638);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.btnAllRandom);
            this.Controls.Add(this.btnRandom3Group);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnClassScore);
            this.Controls.Add(this.btnStudentScore);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHW3";
            this.Text = "FrmHW3";
            this.Load += new System.EventHandler(this.FrmHW3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllRandom;
        private System.Windows.Forms.Button btnRandom3Group;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnClassScore;
        private System.Windows.Forms.Button btnStudentScore;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxStudent;
    }
}