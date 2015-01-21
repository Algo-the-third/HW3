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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCities = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.TabArea = new System.Windows.Forms.TabControl();
            this.annealingTab = new System.Windows.Forms.TabPage();
            this.greedyTab = new System.Windows.Forms.TabPage();
            this.geneticTab = new System.Windows.Forms.TabPage();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.numTemperature = new System.Windows.Forms.NumericUpDown();
            this.numCoolingRate = new System.Windows.Forms.NumericUpDown();
            this.numAbsoluteTemperature = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numGreedyMutationRate = new System.Windows.Forms.NumericUpDown();
            this.numGenerations = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numMutationRate = new System.Windows.Forms.NumericUpDown();
            this.numGenerationSize = new System.Windows.Forms.NumericUpDown();
            this.numPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.numCrossoverRate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chartCities)).BeginInit();
            this.TabArea.SuspendLayout();
            this.annealingTab.SuspendLayout();
            this.greedyTab.SuspendLayout();
            this.geneticTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoolingRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbsoluteTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreedyMutationRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossoverRate)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCities
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCities.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCities.Legends.Add(legend4);
            this.chartCities.Location = new System.Drawing.Point(53, 25);
            this.chartCities.Name = "chartCities";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartCities.Series.Add(series4);
            this.chartCities.Size = new System.Drawing.Size(799, 368);
            this.chartCities.TabIndex = 0;
            this.chartCities.Text = "chartCities";
            this.chartCities.Click += new System.EventHandler(this.chartCities_Click);
            this.chartCities.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartCities_MouseMove);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(54, 659);
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
            // TabArea
            // 
            this.TabArea.Controls.Add(this.annealingTab);
            this.TabArea.Controls.Add(this.greedyTab);
            this.TabArea.Controls.Add(this.geneticTab);
            this.TabArea.Location = new System.Drawing.Point(54, 529);
            this.TabArea.Name = "TabArea";
            this.TabArea.SelectedIndex = 0;
            this.TabArea.Size = new System.Drawing.Size(294, 124);
            this.TabArea.TabIndex = 7;
            // 
            // annealingTab
            // 
            this.annealingTab.Controls.Add(this.label4);
            this.annealingTab.Controls.Add(this.label3);
            this.annealingTab.Controls.Add(this.label2);
            this.annealingTab.Controls.Add(this.numAbsoluteTemperature);
            this.annealingTab.Controls.Add(this.numCoolingRate);
            this.annealingTab.Controls.Add(this.numTemperature);
            this.annealingTab.Location = new System.Drawing.Point(4, 22);
            this.annealingTab.Name = "annealingTab";
            this.annealingTab.Padding = new System.Windows.Forms.Padding(3);
            this.annealingTab.Size = new System.Drawing.Size(286, 98);
            this.annealingTab.TabIndex = 0;
            this.annealingTab.Text = "Simulated Annealing";
            this.annealingTab.UseVisualStyleBackColor = true;
            // 
            // greedyTab
            // 
            this.greedyTab.Controls.Add(this.numGenerations);
            this.greedyTab.Controls.Add(this.numGreedyMutationRate);
            this.greedyTab.Controls.Add(this.label6);
            this.greedyTab.Controls.Add(this.label5);
            this.greedyTab.Location = new System.Drawing.Point(4, 22);
            this.greedyTab.Name = "greedyTab";
            this.greedyTab.Padding = new System.Windows.Forms.Padding(3);
            this.greedyTab.Size = new System.Drawing.Size(286, 98);
            this.greedyTab.TabIndex = 1;
            this.greedyTab.Text = "Greedy Strategy";
            this.greedyTab.UseVisualStyleBackColor = true;
            // 
            // geneticTab
            // 
            this.geneticTab.Controls.Add(this.numCrossoverRate);
            this.geneticTab.Controls.Add(this.numPopulationSize);
            this.geneticTab.Controls.Add(this.numGenerationSize);
            this.geneticTab.Controls.Add(this.numMutationRate);
            this.geneticTab.Controls.Add(this.label10);
            this.geneticTab.Controls.Add(this.label9);
            this.geneticTab.Controls.Add(this.label8);
            this.geneticTab.Controls.Add(this.label7);
            this.geneticTab.Location = new System.Drawing.Point(4, 22);
            this.geneticTab.Name = "geneticTab";
            this.geneticTab.Size = new System.Drawing.Size(286, 98);
            this.geneticTab.TabIndex = 2;
            this.geneticTab.Text = "Genetic Algorithm";
            this.geneticTab.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(376, 399);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(476, 292);
            this.resultTextBox.TabIndex = 8;
            this.resultTextBox.Text = "";
            // 
            // numTemperature
            // 
            this.numTemperature.Location = new System.Drawing.Point(26, 39);
            this.numTemperature.Name = "numTemperature";
            this.numTemperature.Size = new System.Drawing.Size(64, 20);
            this.numTemperature.TabIndex = 0;
            this.numTemperature.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // numCoolingRate
            // 
            this.numCoolingRate.Location = new System.Drawing.Point(115, 39);
            this.numCoolingRate.Name = "numCoolingRate";
            this.numCoolingRate.Size = new System.Drawing.Size(64, 20);
            this.numCoolingRate.TabIndex = 1;
            this.numCoolingRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numAbsoluteTemperature
            // 
            this.numAbsoluteTemperature.Location = new System.Drawing.Point(201, 39);
            this.numAbsoluteTemperature.Name = "numAbsoluteTemperature";
            this.numAbsoluteTemperature.Size = new System.Drawing.Size(64, 20);
            this.numAbsoluteTemperature.TabIndex = 2;
            this.numAbsoluteTemperature.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cooling Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Absolute \r\nTemperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mutation Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Generations";
            // 
            // numGreedyMutationRate
            // 
            this.numGreedyMutationRate.Location = new System.Drawing.Point(40, 44);
            this.numGreedyMutationRate.Name = "numGreedyMutationRate";
            this.numGreedyMutationRate.Size = new System.Drawing.Size(64, 20);
            this.numGreedyMutationRate.TabIndex = 2;
            // 
            // numGenerations
            // 
            this.numGenerations.Location = new System.Drawing.Point(169, 44);
            this.numGenerations.Name = "numGenerations";
            this.numGenerations.Size = new System.Drawing.Size(61, 20);
            this.numGenerations.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mutation Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Crossover Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Population Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Generation Size";
            // 
            // numMutationRate
            // 
            this.numMutationRate.Location = new System.Drawing.Point(20, 29);
            this.numMutationRate.Name = "numMutationRate";
            this.numMutationRate.Size = new System.Drawing.Size(64, 20);
            this.numMutationRate.TabIndex = 4;
            // 
            // numGenerationSize
            // 
            this.numGenerationSize.Location = new System.Drawing.Point(173, 71);
            this.numGenerationSize.Name = "numGenerationSize";
            this.numGenerationSize.Size = new System.Drawing.Size(64, 20);
            this.numGenerationSize.TabIndex = 5;
            // 
            // numPopulationSize
            // 
            this.numPopulationSize.Location = new System.Drawing.Point(20, 71);
            this.numPopulationSize.Name = "numPopulationSize";
            this.numPopulationSize.Size = new System.Drawing.Size(64, 20);
            this.numPopulationSize.TabIndex = 5;
            // 
            // numCrossoverRate
            // 
            this.numCrossoverRate.Location = new System.Drawing.Point(173, 29);
            this.numCrossoverRate.Name = "numCrossoverRate";
            this.numCrossoverRate.Size = new System.Drawing.Size(64, 20);
            this.numCrossoverRate.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 709);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.TabArea);
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
            this.TabArea.ResumeLayout(false);
            this.annealingTab.ResumeLayout(false);
            this.annealingTab.PerformLayout();
            this.greedyTab.ResumeLayout(false);
            this.greedyTab.PerformLayout();
            this.geneticTab.ResumeLayout(false);
            this.geneticTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoolingRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbsoluteTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreedyMutationRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossoverRate)).EndInit();
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
        private System.Windows.Forms.TabControl TabArea;
        private System.Windows.Forms.TabPage annealingTab;
        private System.Windows.Forms.TabPage greedyTab;
        private System.Windows.Forms.TabPage geneticTab;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAbsoluteTemperature;
        private System.Windows.Forms.NumericUpDown numCoolingRate;
        private System.Windows.Forms.NumericUpDown numTemperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numGenerations;
        private System.Windows.Forms.NumericUpDown numGreedyMutationRate;
        private System.Windows.Forms.NumericUpDown numCrossoverRate;
        private System.Windows.Forms.NumericUpDown numPopulationSize;
        private System.Windows.Forms.NumericUpDown numGenerationSize;
        private System.Windows.Forms.NumericUpDown numMutationRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

