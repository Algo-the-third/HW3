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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TabArea = new System.Windows.Forms.TabControl();
            this.annealingTab = new System.Windows.Forms.TabPage();
            this.txtAbsoluteTemperature = new System.Windows.Forms.TextBox();
            this.txtCoolingRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTemperature = new System.Windows.Forms.NumericUpDown();
            this.greedyTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.geneticTab = new System.Windows.Forms.TabPage();
            this.elistimRate = new System.Windows.Forms.Label();
            this.elitismCheckbox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numElitismRatio = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numMixingRatio = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numGenomeSize = new System.Windows.Forms.NumericUpDown();
            this.numCrossoverRate = new System.Windows.Forms.NumericUpDown();
            this.numPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.numGenerationSize = new System.Windows.Forms.NumericUpDown();
            this.numMutationRate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.btnRandomRoute = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.calculatingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCities)).BeginInit();
            this.TabArea.SuspendLayout();
            this.annealingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperature)).BeginInit();
            this.greedyTab.SuspendLayout();
            this.geneticTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numElitismRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMixingRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenomeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossoverRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationRate)).BeginInit();
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
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(53, 399);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(165, 169);
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
            this.label1.Location = new System.Drawing.Point(225, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Route Distance:";
            // 
            // TabArea
            // 
            this.TabArea.Controls.Add(this.annealingTab);
            this.TabArea.Controls.Add(this.greedyTab);
            this.TabArea.Controls.Add(this.geneticTab);
            this.TabArea.Location = new System.Drawing.Point(53, 574);
            this.TabArea.Name = "TabArea";
            this.TabArea.SelectedIndex = 0;
            this.TabArea.Size = new System.Drawing.Size(311, 174);
            this.TabArea.TabIndex = 7;
            // 
            // annealingTab
            // 
            this.annealingTab.Controls.Add(this.txtAbsoluteTemperature);
            this.annealingTab.Controls.Add(this.txtCoolingRate);
            this.annealingTab.Controls.Add(this.label4);
            this.annealingTab.Controls.Add(this.label3);
            this.annealingTab.Controls.Add(this.label2);
            this.annealingTab.Controls.Add(this.numTemperature);
            this.annealingTab.Location = new System.Drawing.Point(4, 22);
            this.annealingTab.Name = "annealingTab";
            this.annealingTab.Padding = new System.Windows.Forms.Padding(3);
            this.annealingTab.Size = new System.Drawing.Size(303, 148);
            this.annealingTab.TabIndex = 0;
            this.annealingTab.Text = "Simulated Annealing";
            this.annealingTab.UseVisualStyleBackColor = true;
            // 
            // txtAbsoluteTemperature
            // 
            this.txtAbsoluteTemperature.Location = new System.Drawing.Point(201, 38);
            this.txtAbsoluteTemperature.Name = "txtAbsoluteTemperature";
            this.txtAbsoluteTemperature.Size = new System.Drawing.Size(64, 20);
            this.txtAbsoluteTemperature.TabIndex = 7;
            this.txtAbsoluteTemperature.Text = "0,00001";
            // 
            // txtCoolingRate
            // 
            this.txtCoolingRate.Location = new System.Drawing.Point(114, 38);
            this.txtCoolingRate.Name = "txtCoolingRate";
            this.txtCoolingRate.Size = new System.Drawing.Size(65, 20);
            this.txtCoolingRate.TabIndex = 6;
            this.txtCoolingRate.Text = "0,9999";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cooling Rate";
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
            // numTemperature
            // 
            this.numTemperature.Location = new System.Drawing.Point(26, 39);
            this.numTemperature.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTemperature.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numTemperature.Name = "numTemperature";
            this.numTemperature.Size = new System.Drawing.Size(64, 20);
            this.numTemperature.TabIndex = 0;
            this.numTemperature.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // greedyTab
            // 
            this.greedyTab.Controls.Add(this.label6);
            this.greedyTab.Location = new System.Drawing.Point(4, 22);
            this.greedyTab.Name = "greedyTab";
            this.greedyTab.Padding = new System.Windows.Forms.Padding(3);
            this.greedyTab.Size = new System.Drawing.Size(303, 148);
            this.greedyTab.TabIndex = 1;
            this.greedyTab.Text = "Greedy Strategy";
            this.greedyTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "No options available for this strategy.";
            // 
            // geneticTab
            // 
            this.geneticTab.Controls.Add(this.elistimRate);
            this.geneticTab.Controls.Add(this.elitismCheckbox);
            this.geneticTab.Controls.Add(this.label12);
            this.geneticTab.Controls.Add(this.numElitismRatio);
            this.geneticTab.Controls.Add(this.label11);
            this.geneticTab.Controls.Add(this.numMixingRatio);
            this.geneticTab.Controls.Add(this.label5);
            this.geneticTab.Controls.Add(this.numGenomeSize);
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
            this.geneticTab.Size = new System.Drawing.Size(303, 148);
            this.geneticTab.TabIndex = 2;
            this.geneticTab.Text = "Genetic Algorithm";
            this.geneticTab.UseVisualStyleBackColor = true;
            // 
            // elistimRate
            // 
            this.elistimRate.AutoSize = true;
            this.elistimRate.Location = new System.Drawing.Point(201, 99);
            this.elistimRate.Name = "elistimRate";
            this.elistimRate.Size = new System.Drawing.Size(0, 13);
            this.elistimRate.TabIndex = 15;
            // 
            // elitismCheckbox
            // 
            this.elitismCheckbox.AutoSize = true;
            this.elitismCheckbox.Checked = true;
            this.elitismCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.elitismCheckbox.Location = new System.Drawing.Point(204, 35);
            this.elitismCheckbox.Name = "elitismCheckbox";
            this.elitismCheckbox.Size = new System.Drawing.Size(96, 17);
            this.elitismCheckbox.TabIndex = 14;
            this.elitismCheckbox.Text = "activate Elistim";
            this.elitismCheckbox.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Elisitm Genomes";
            // 
            // numElitismRatio
            // 
            this.numElitismRatio.Location = new System.Drawing.Point(204, 71);
            this.numElitismRatio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numElitismRatio.Name = "numElitismRatio";
            this.numElitismRatio.Size = new System.Drawing.Size(64, 20);
            this.numElitismRatio.TabIndex = 13;
            this.numElitismRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numElitismRatio.ValueChanged += new System.EventHandler(this.numElitismRatio_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Mixing Ratio";
            // 
            // numMixingRatio
            // 
            this.numMixingRatio.DecimalPlaces = 2;
            this.numMixingRatio.Location = new System.Drawing.Point(119, 115);
            this.numMixingRatio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMixingRatio.Name = "numMixingRatio";
            this.numMixingRatio.Size = new System.Drawing.Size(64, 20);
            this.numMixingRatio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Genome Size";
            // 
            // numGenomeSize
            // 
            this.numGenomeSize.Enabled = false;
            this.numGenomeSize.Location = new System.Drawing.Point(20, 115);
            this.numGenomeSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numGenomeSize.Name = "numGenomeSize";
            this.numGenomeSize.Size = new System.Drawing.Size(64, 20);
            this.numGenomeSize.TabIndex = 10;
            this.numGenomeSize.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // numCrossoverRate
            // 
            this.numCrossoverRate.DecimalPlaces = 2;
            this.numCrossoverRate.Location = new System.Drawing.Point(119, 29);
            this.numCrossoverRate.Name = "numCrossoverRate";
            this.numCrossoverRate.Size = new System.Drawing.Size(64, 20);
            this.numCrossoverRate.TabIndex = 6;
            this.numCrossoverRate.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // numPopulationSize
            // 
            this.numPopulationSize.Location = new System.Drawing.Point(20, 71);
            this.numPopulationSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPopulationSize.Name = "numPopulationSize";
            this.numPopulationSize.Size = new System.Drawing.Size(64, 20);
            this.numPopulationSize.TabIndex = 5;
            this.numPopulationSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPopulationSize.ValueChanged += new System.EventHandler(this.numPopulationSize_ValueChanged);
            // 
            // numGenerationSize
            // 
            this.numGenerationSize.Location = new System.Drawing.Point(119, 71);
            this.numGenerationSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGenerationSize.Name = "numGenerationSize";
            this.numGenerationSize.Size = new System.Drawing.Size(64, 20);
            this.numGenerationSize.TabIndex = 5;
            this.numGenerationSize.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numMutationRate
            // 
            this.numMutationRate.DecimalPlaces = 2;
            this.numMutationRate.Location = new System.Drawing.Point(20, 29);
            this.numMutationRate.Name = "numMutationRate";
            this.numMutationRate.Size = new System.Drawing.Size(64, 20);
            this.numMutationRate.TabIndex = 4;
            this.numMutationRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Generation Size";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Crossover Rate in %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mutation Rate in %";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(370, 399);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(498, 295);
            this.resultTextBox.TabIndex = 8;
            this.resultTextBox.Text = "";
            // 
            // btnRandomRoute
            // 
            this.btnRandomRoute.Location = new System.Drawing.Point(224, 474);
            this.btnRandomRoute.Name = "btnRandomRoute";
            this.btnRandomRoute.Size = new System.Drawing.Size(124, 32);
            this.btnRandomRoute.TabIndex = 9;
            this.btnRandomRoute.Text = "Random route";
            this.btnRandomRoute.UseVisualStyleBackColor = true;
            this.btnRandomRoute.Click += new System.EventHandler(this.btnRandomRoute_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(370, 700);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(153, 31);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(225, 541);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 13);
            this.distanceLabel.TabIndex = 11;
            // 
            // calculatingLabel
            // 
            this.calculatingLabel.AutoSize = true;
            this.calculatingLabel.Location = new System.Drawing.Point(546, 709);
            this.calculatingLabel.Name = "calculatingLabel";
            this.calculatingLabel.Size = new System.Drawing.Size(0, 13);
            this.calculatingLabel.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 742);
            this.Controls.Add(this.calculatingLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnRandomRoute);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.TabArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.chartCities);
            this.Name = "MainForm";
            this.Text = "TCP - Winterterm 2014/15 - Felix Griewald, Sascha Feldmann, Marco Seidler";
            ((System.ComponentModel.ISupportInitialize)(this.chartCities)).EndInit();
            this.TabArea.ResumeLayout(false);
            this.annealingTab.ResumeLayout(false);
            this.annealingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperature)).EndInit();
            this.greedyTab.ResumeLayout(false);
            this.greedyTab.PerformLayout();
            this.geneticTab.ResumeLayout(false);
            this.geneticTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numElitismRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMixingRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenomeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossoverRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCities;

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.TabControl TabArea;
        private System.Windows.Forms.TabPage annealingTab;
        private System.Windows.Forms.TabPage greedyTab;
        private System.Windows.Forms.TabPage geneticTab;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTemperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCrossoverRate;
        private System.Windows.Forms.NumericUpDown numPopulationSize;
        private System.Windows.Forms.NumericUpDown numGenerationSize;
        private System.Windows.Forms.NumericUpDown numMutationRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAbsoluteTemperature;
        private System.Windows.Forms.TextBox txtCoolingRate;
        private System.Windows.Forms.Button btnRandomRoute;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numMixingRatio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numGenomeSize;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numElitismRatio;
        private System.Windows.Forms.CheckBox elitismCheckbox;
        private System.Windows.Forms.Label elistimRate;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label calculatingLabel;
    }
}

