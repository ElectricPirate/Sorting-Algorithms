namespace Sorting_Algorithms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNumbersPanel = new System.Windows.Forms.Panel();
            this.AddLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.FillRandomPanel = new System.Windows.Forms.Panel();
            this.FillRandomLabel = new System.Windows.Forms.Label();
            this.FillRandomButton = new System.Windows.Forms.Button();
            this.AmountRandomTextBox = new System.Windows.Forms.TextBox();
            this.VisualizationPanel = new System.Windows.Forms.Panel();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.CocktailSortButton = new System.Windows.Forms.Button();
            this.SwopsLabel = new System.Windows.Forms.Label();
            this.ComparsionsLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.AddNumbersPanel.SuspendLayout();
            this.FillRandomPanel.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNumbersPanel
            // 
            this.AddNumbersPanel.Controls.Add(this.AddLabel);
            this.AddNumbersPanel.Controls.Add(this.AddButton);
            this.AddNumbersPanel.Controls.Add(this.AddTextBox);
            this.AddNumbersPanel.Location = new System.Drawing.Point(0, 0);
            this.AddNumbersPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddNumbersPanel.Name = "AddNumbersPanel";
            this.AddNumbersPanel.Size = new System.Drawing.Size(295, 70);
            this.AddNumbersPanel.TabIndex = 0;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Location = new System.Drawing.Point(18, 11);
            this.AddLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(74, 15);
            this.AddLabel.TabIndex = 2;
            this.AddLabel.Text = "Add number";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(191, 29);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(18, 29);
            this.AddTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(165, 23);
            this.AddTextBox.TabIndex = 0;
            // 
            // FillRandomPanel
            // 
            this.FillRandomPanel.Controls.Add(this.FillRandomLabel);
            this.FillRandomPanel.Controls.Add(this.FillRandomButton);
            this.FillRandomPanel.Controls.Add(this.AmountRandomTextBox);
            this.FillRandomPanel.Location = new System.Drawing.Point(0, 77);
            this.FillRandomPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FillRandomPanel.Name = "FillRandomPanel";
            this.FillRandomPanel.Size = new System.Drawing.Size(295, 70);
            this.FillRandomPanel.TabIndex = 3;
            // 
            // FillRandomLabel
            // 
            this.FillRandomLabel.AutoSize = true;
            this.FillRandomLabel.Location = new System.Drawing.Point(18, 11);
            this.FillRandomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FillRandomLabel.Name = "FillRandomLabel";
            this.FillRandomLabel.Size = new System.Drawing.Size(165, 15);
            this.FillRandomLabel.TabIndex = 2;
            this.FillRandomLabel.Text = "Fill random numbers, amount";
            // 
            // FillRandomButton
            // 
            this.FillRandomButton.Location = new System.Drawing.Point(191, 29);
            this.FillRandomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FillRandomButton.Name = "FillRandomButton";
            this.FillRandomButton.Size = new System.Drawing.Size(88, 23);
            this.FillRandomButton.TabIndex = 1;
            this.FillRandomButton.Text = "Fill";
            this.FillRandomButton.UseVisualStyleBackColor = true;
            this.FillRandomButton.Click += new System.EventHandler(this.FillRandomButton_Click);
            // 
            // AmountRandomTextBox
            // 
            this.AmountRandomTextBox.Location = new System.Drawing.Point(18, 29);
            this.AmountRandomTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AmountRandomTextBox.Name = "AmountRandomTextBox";
            this.AmountRandomTextBox.Size = new System.Drawing.Size(165, 23);
            this.AmountRandomTextBox.TabIndex = 0;
            // 
            // VisualizationPanel
            // 
            this.VisualizationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisualizationPanel.Location = new System.Drawing.Point(0, 153);
            this.VisualizationPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VisualizationPanel.Name = "VisualizationPanel";
            this.VisualizationPanel.Size = new System.Drawing.Size(933, 148);
            this.VisualizationPanel.TabIndex = 4;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Controls.Add(this.HeapSortButton);
            this.ControlsPanel.Controls.Add(this.TreeSortButton);
            this.ControlsPanel.Controls.Add(this.ShellSortButton);
            this.ControlsPanel.Controls.Add(this.InsertSortButton);
            this.ControlsPanel.Controls.Add(this.CocktailSortButton);
            this.ControlsPanel.Controls.Add(this.SwopsLabel);
            this.ControlsPanel.Controls.Add(this.ComparsionsLabel);
            this.ControlsPanel.Controls.Add(this.TimeLabel);
            this.ControlsPanel.Controls.Add(this.BubbleSortButton);
            this.ControlsPanel.Controls.Add(this.ClearButton);
            this.ControlsPanel.Location = new System.Drawing.Point(302, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(631, 147);
            this.ControlsPanel.TabIndex = 5;
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Location = new System.Drawing.Point(186, 105);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(80, 23);
            this.InsertSortButton.TabIndex = 6;
            this.InsertSortButton.Text = "InsertSort";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // CocktailSortButton
            // 
            this.CocktailSortButton.Location = new System.Drawing.Point(100, 105);
            this.CocktailSortButton.Name = "CocktailSortButton";
            this.CocktailSortButton.Size = new System.Drawing.Size(80, 23);
            this.CocktailSortButton.TabIndex = 5;
            this.CocktailSortButton.Text = "CocktailSort";
            this.CocktailSortButton.UseVisualStyleBackColor = true;
            this.CocktailSortButton.Click += new System.EventHandler(this.CocktailSortButton_Click);
            // 
            // SwopsLabel
            // 
            this.SwopsLabel.AutoSize = true;
            this.SwopsLabel.Location = new System.Drawing.Point(14, 85);
            this.SwopsLabel.Name = "SwopsLabel";
            this.SwopsLabel.Size = new System.Drawing.Size(44, 15);
            this.SwopsLabel.TabIndex = 4;
            this.SwopsLabel.Text = "Swops:";
            // 
            // ComparsionsLabel
            // 
            this.ComparsionsLabel.AutoSize = true;
            this.ComparsionsLabel.Location = new System.Drawing.Point(14, 70);
            this.ComparsionsLabel.Name = "ComparsionsLabel";
            this.ComparsionsLabel.Size = new System.Drawing.Size(59, 15);
            this.ComparsionsLabel.TabIndex = 3;
            this.ComparsionsLabel.Text = "Compare:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(14, 55);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(39, 15);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Time: ";
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(14, 105);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(80, 23);
            this.BubbleSortButton.TabIndex = 1;
            this.BubbleSortButton.Text = "BubbleSort";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(14, 29);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.Location = new System.Drawing.Point(272, 105);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(80, 23);
            this.ShellSortButton.TabIndex = 7;
            this.ShellSortButton.Text = "ShellSort";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(358, 105);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(80, 23);
            this.TreeSortButton.TabIndex = 8;
            this.TreeSortButton.Text = "TreeSort";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(444, 105);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(80, 23);
            this.HeapSortButton.TabIndex = 9;
            this.HeapSortButton.Text = "HeapSort";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.VisualizationPanel);
            this.Controls.Add(this.FillRandomPanel);
            this.Controls.Add(this.AddNumbersPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Fun with algorithms";
            this.AddNumbersPanel.ResumeLayout(false);
            this.AddNumbersPanel.PerformLayout();
            this.FillRandomPanel.ResumeLayout(false);
            this.FillRandomPanel.PerformLayout();
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Panel AddNumbersPanel;
        private System.Windows.Forms.Label FillRandomLabel;
        private System.Windows.Forms.Button FillRandomButton;
        private System.Windows.Forms.TextBox AmountRandomTextBox;
        private System.Windows.Forms.Panel FillRandomPanel;
        private System.Windows.Forms.Panel VisualizationPanel;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ComparsionsLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label SwopsLabel;
        private System.Windows.Forms.Button CocktailSortButton;
        private System.Windows.Forms.Button InsertSortButton;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.Button TreeSortButton;
        private System.Windows.Forms.Button ShellSortButton;
    }
}

