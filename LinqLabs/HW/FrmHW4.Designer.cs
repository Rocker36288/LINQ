namespace LinqLabs.HW
{
    partial class FrmHW4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGroupByYearMonth = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnTop5Price = new System.Windows.Forms.Button();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnProductPrice = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnTop5Sales = new System.Windows.Forms.Button();
            this.btnGroupByYear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(38, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 34);
            this.button3.TabIndex = 150;
            this.button3.Text = "年 銷售成長率";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 22);
            this.label3.TabIndex = 149;
            this.label3.Text = "LINQ to Northwind Entity";
            // 
            // btnGroupByYearMonth
            // 
            this.btnGroupByYearMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGroupByYearMonth.Location = new System.Drawing.Point(30, 365);
            this.btnGroupByYearMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupByYearMonth.Name = "btnGroupByYearMonth";
            this.btnGroupByYearMonth.Size = new System.Drawing.Size(268, 34);
            this.btnGroupByYearMonth.TabIndex = 148;
            this.btnGroupByYearMonth.Text = " Orders -  Group by 年 / 月";
            this.btnGroupByYearMonth.UseVisualStyleBackColor = false;
            this.btnGroupByYearMonth.Click += new System.EventHandler(this.btnGroupByYearMonth_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 145;
            this.label4.Text = "LINQ - GroupBy";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(30, 60);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(268, 34);
            this.button4.TabIndex = 138;
            this.button4.Text = "int[]  分三群 - No LINQ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnTop5Price
            // 
            this.btnTop5Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTop5Price.Location = new System.Drawing.Point(30, 494);
            this.btnTop5Price.Margin = new System.Windows.Forms.Padding(4);
            this.btnTop5Price.Name = "btnTop5Price";
            this.btnTop5Price.Size = new System.Drawing.Size(268, 34);
            this.btnTop5Price.TabIndex = 139;
            this.btnTop5Price.Text = "     NW 產品最高單價前 5 筆";
            this.btnTop5Price.UseVisualStyleBackColor = false;
            this.btnTop5Price.Click += new System.EventHandler(this.btnTop5Price_Click);
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTotalPrice.Location = new System.Drawing.Point(30, 408);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(268, 34);
            this.btnTotalPrice.TabIndex = 147;
            this.btnTotalPrice.Text = "總銷售金額";
            this.btnTotalPrice.UseVisualStyleBackColor = false;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 146;
            this.label1.Text = "LINQ to FileInfo[]";
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnYear.ForeColor = System.Drawing.Color.Black;
            this.btnYear.Location = new System.Drawing.Point(30, 179);
            this.btnYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(268, 34);
            this.btnYear.TabIndex = 140;
            this.btnYear.Text = "  依 年 分組檔案 (大=>小)";
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnProductPrice
            // 
            this.btnProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnProductPrice.ForeColor = System.Drawing.Color.Black;
            this.btnProductPrice.Location = new System.Drawing.Point(30, 279);
            this.btnProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductPrice.Name = "btnProductPrice";
            this.btnProductPrice.Size = new System.Drawing.Size(268, 34);
            this.btnProductPrice.TabIndex = 141;
            this.btnProductPrice.Text = "NW Products 低中高 價產品 ";
            this.btnProductPrice.UseVisualStyleBackColor = false;
            this.btnProductPrice.Click += new System.EventHandler(this.btnProductPrice_Click);
            // 
            // btnSize
            // 
            this.btnSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSize.ForeColor = System.Drawing.Color.Black;
            this.btnSize.Location = new System.Drawing.Point(30, 137);
            this.btnSize.Margin = new System.Windows.Forms.Padding(4);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(268, 34);
            this.btnSize.TabIndex = 142;
            this.btnSize.Text = "依 檔案大小 分組檔案 (大=>小)";
            this.btnSize.UseVisualStyleBackColor = false;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnTop5Sales
            // 
            this.btnTop5Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTop5Sales.Location = new System.Drawing.Point(30, 451);
            this.btnTop5Sales.Name = "btnTop5Sales";
            this.btnTop5Sales.Size = new System.Drawing.Size(268, 34);
            this.btnTop5Sales.TabIndex = 144;
            this.btnTop5Sales.Text = "銷售最好的top 5業務員";
            this.btnTop5Sales.UseVisualStyleBackColor = false;
            this.btnTop5Sales.Click += new System.EventHandler(this.btnTop5Sales_Click);
            // 
            // btnGroupByYear
            // 
            this.btnGroupByYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGroupByYear.Location = new System.Drawing.Point(30, 322);
            this.btnGroupByYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupByYear.Name = "btnGroupByYear";
            this.btnGroupByYear.Size = new System.Drawing.Size(268, 34);
            this.btnGroupByYear.TabIndex = 143;
            this.btnGroupByYear.Text = " Orders -  Group by 年";
            this.btnGroupByYear.UseVisualStyleBackColor = false;
            this.btnGroupByYear.Click += new System.EventHandler(this.btnGroupByYear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 145;
            this.label2.Text = "Main";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 145;
            this.label5.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(341, 150);
            this.dataGridView1.TabIndex = 151;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(360, 405);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(695, 210);
            this.chart1.TabIndex = 152;
            this.chart1.Text = "chart1";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(360, 209);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(695, 190);
            this.treeView1.TabIndex = 153;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(707, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(348, 150);
            this.dataGridView2.TabIndex = 151;
            // 
            // FrmHW4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 638);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGroupByYearMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTop5Price);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnProductPrice);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.btnTop5Sales);
            this.Controls.Add(this.btnGroupByYear);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHW4";
            this.Text = "FrmHW4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGroupByYearMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTop5Price;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnProductPrice;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnTop5Sales;
        private System.Windows.Forms.Button btnGroupByYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}