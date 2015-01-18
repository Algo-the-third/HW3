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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCities = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCities)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCities
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCities.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCities.Legends.Add(legend1);
            this.chartCities.Location = new System.Drawing.Point(53, 25);
            this.chartCities.Name = "chartCities";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCities.Series.Add(series1);
            this.chartCities.Size = new System.Drawing.Size(799, 368);
            this.chartCities.TabIndex = 0;
            this.chartCities.Text = "chartCities";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(53, 399);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 32);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 646);
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
    }
}

