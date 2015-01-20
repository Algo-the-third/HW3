namespace TSP
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCities = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCities)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCities
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCities.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCities.Legends.Add(legend2);
            this.chartCities.Location = new System.Drawing.Point(53, 25);
            this.chartCities.Name = "chartCities";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCities.Series.Add(series2);
            this.chartCities.Size = new System.Drawing.Size(799, 368);
            this.chartCities.TabIndex = 0;
            this.chartCities.Text = "chartCities";
            this.chartCities.Click += new System.EventHandler(this.chartCities_Click);
            this.chartCities.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartCities_MouseMove);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(728, 491);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 32);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(53, 399);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(165, 124);
            this.checkedListBox.TabIndex = 2;
            this.checkedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_SelectedIndexChanged);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(224, 399);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(124, 32);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(224, 437);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(124, 31);
            this.btnSelectNone.TabIndex = 4;
            this.btnSelectNone.Text = "select none";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 646);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chartCities);
            this.Name = "MainForm";
            this.Text = "TCP - Winterterm 2014/15 - Felix Griewald, Sascha Feldmann, Marco Seidler";
            ((System.ComponentModel.ISupportInitialize)(this.chartCities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCities;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
    }
}

