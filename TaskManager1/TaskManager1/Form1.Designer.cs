namespace TaskManager1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Processes = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Performance = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Info = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ramC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.Processes.SuspendLayout();
            this.Performance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Processes);
            this.tabControl1.Controls.Add(this.Performance);
            this.tabControl1.Controls.Add(this.Info);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // Processes
            // 
            this.Processes.Controls.Add(this.button1);
            this.Processes.Controls.Add(this.textBox1);
            this.Processes.Controls.Add(this.start);
            this.Processes.Controls.Add(this.end);
            this.Processes.Controls.Add(this.listView1);
            this.Processes.Location = new System.Drawing.Point(4, 25);
            this.Processes.Name = "Processes";
            this.Processes.Padding = new System.Windows.Forms.Padding(3);
            this.Processes.Size = new System.Drawing.Size(630, 519);
            this.Processes.TabIndex = 0;
            this.Processes.Text = "Proceses";
            this.Processes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(97, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(7, 375);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(83, 33);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(444, 375);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(107, 33);
            this.end.TabIndex = 1;
            this.end.Text = "End Task";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameC,
            this.idc,
            this.ramC,
            this.cpuc});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(545, 363);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nameC
            // 
            this.nameC.Text = "Name";
            this.nameC.Width = 155;
            // 
            // idc
            // 
            this.idc.Text = "ID";
            this.idc.Width = 75;
            // 
            // cpuc
            // 
            this.cpuc.Text = "CPU";
            this.cpuc.Width = 66;
            // 
            // Performance
            // 
            this.Performance.Controls.Add(this.chart2);
            this.Performance.Controls.Add(this.chart1);
            this.Performance.Location = new System.Drawing.Point(4, 25);
            this.Performance.Name = "Performance";
            this.Performance.Padding = new System.Windows.Forms.Padding(3);
            this.Performance.Size = new System.Drawing.Size(630, 519);
            this.Performance.TabIndex = 1;
            this.Performance.Text = "Performance";
            this.Performance.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(6, 250);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "RAM%";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(618, 263);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "CPU%";
            series2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(618, 238);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Info
            // 
            this.Info.Controls.Add(this.label1);
            this.Info.Location = new System.Drawing.Point(4, 25);
            this.Info.Name = "Info";
            this.Info.Padding = new System.Windows.Forms.Padding(3);
            this.Info.Size = new System.Drawing.Size(630, 519);
            this.Info.TabIndex = 2;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ramC
            // 
            this.ramC.Text = "RAM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 572);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TaskManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Processes.ResumeLayout(false);
            this.Processes.PerformLayout();
            this.Performance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Processes;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage Performance;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ColumnHeader nameC;
        private System.Windows.Forms.ColumnHeader idc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader cpuc;
        private System.Windows.Forms.ColumnHeader ramC;
    }
}

