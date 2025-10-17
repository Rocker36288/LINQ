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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnProductPrice = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nwDataSet1 = new LinqLabs.NWDataSet();
            this.productsTableAdapter1 = new LinqLabs.NWDataSetTableAdapters.ProductsTableAdapter();
            this.ordersTableAdapter1 = new LinqLabs.NWDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 149;
            this.label3.Text = "LINQ to Northwind Entity";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button10.Location = new System.Drawing.Point(30, 365);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(268, 34);
            this.button10.TabIndex = 148;
            this.button10.Text = " Orders -  Group by 年 / 月";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
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
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(30, 494);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(268, 34);
            this.button9.TabIndex = 139;
            this.button9.Text = "     NW 產品最高單價前 5 筆";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(30, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 34);
            this.button2.TabIndex = 147;
            this.button2.Text = "總銷售金額";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(30, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 34);
            this.button1.TabIndex = 144;
            this.button1.Text = "銷售最好的top 5業務員";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button15.Location = new System.Drawing.Point(30, 322);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(268, 34);
            this.button15.TabIndex = 143;
            this.button15.Text = " Orders -  Group by 年";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 145;
            this.label2.Text = "Main";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(360, 405);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 210);
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
            // nwDataSet1
            // 
            this.nwDataSet1.DataSetName = "NWDataSet";
            this.nwDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmHW4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 638);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnProductPrice);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button15);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHW4";
            this.Text = "FrmHW4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnProductPrice;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private NWDataSet nwDataSet1;
        private NWDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private NWDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
    }
}