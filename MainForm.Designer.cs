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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Route Distance:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(224, 491);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 13);
            this.distanceLabel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 646);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chartCities);
            this.Name = "MainForm";
            this.Text = "TCP - Winterterm 2014/15 - Felix Griewald, Sascha Feldmann, Marco Seidler";
            ((System.ComponentModel.ISupportInitialize)(this.chartCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCities;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label distanceLabel;
    }
}

