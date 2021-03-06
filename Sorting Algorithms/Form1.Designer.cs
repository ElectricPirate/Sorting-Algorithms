﻿namespace Sorting_Algorithms
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
            this.BogoSortButton = new System.Windows.Forms.Button();
            this.QuickSortButton = new System.Windows.Forms.Button();
            this.RadixMSDSortButton = new System.Windows.Forms.Button();
            this.RadixLSDSortButton = new System.Windows.Forms.Button();
            this.MergeSortButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.SelectionSortButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.CocktailSortButton = new System.Windows.Forms.Button();
            this.SwopsLabel = new System.Windows.Forms.Label();
            this.ComparsionsLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DangerousGroup = new System.Windows.Forms.GroupBox();
            this.AddNumbersPanel.SuspendLayout();
            this.FillRandomPanel.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            this.DangerousGroup.SuspendLayout();
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
            this.ControlsPanel.Controls.Add(this.DangerousGroup);
            this.ControlsPanel.Controls.Add(this.QuickSortButton);
            this.ControlsPanel.Controls.Add(this.RadixMSDSortButton);
            this.ControlsPanel.Controls.Add(this.RadixLSDSortButton);
            this.ControlsPanel.Controls.Add(this.MergeSortButton);
            this.ControlsPanel.Controls.Add(this.TreeSortButton);
            this.ControlsPanel.Controls.Add(this.GnomeSortButton);
            this.ControlsPanel.Controls.Add(this.HeapSortButton);
            this.ControlsPanel.Controls.Add(this.SelectionSortButton);
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
            // BogoSortButton
            // 
            this.BogoSortButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BogoSortButton.Location = new System.Drawing.Point(6, 17);
            this.BogoSortButton.Name = "BogoSortButton";
            this.BogoSortButton.Size = new System.Drawing.Size(81, 23);
            this.BogoSortButton.TabIndex = 16;
            this.BogoSortButton.Text = "BogoSort";
            this.BogoSortButton.UseVisualStyleBackColor = true;
            this.BogoSortButton.Click += new System.EventHandler(this.BogoSortButton_Click);
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Location = new System.Drawing.Point(408, 87);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(85, 23);
            this.QuickSortButton.TabIndex = 15;
            this.QuickSortButton.Text = "QuickSort";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // RadixMSDSortButton
            // 
            this.RadixMSDSortButton.Location = new System.Drawing.Point(408, 58);
            this.RadixMSDSortButton.Name = "RadixMSDSortButton";
            this.RadixMSDSortButton.Size = new System.Drawing.Size(85, 23);
            this.RadixMSDSortButton.TabIndex = 14;
            this.RadixMSDSortButton.Text = "Radix MSD Sort";
            this.RadixMSDSortButton.UseVisualStyleBackColor = true;
            this.RadixMSDSortButton.Click += new System.EventHandler(this.RadixMSDSortButton_Click);
            // 
            // RadixLSDSortButton
            // 
            this.RadixLSDSortButton.Location = new System.Drawing.Point(408, 29);
            this.RadixLSDSortButton.Name = "RadixLSDSortButton";
            this.RadixLSDSortButton.Size = new System.Drawing.Size(85, 23);
            this.RadixLSDSortButton.TabIndex = 13;
            this.RadixLSDSortButton.Text = "RadixLSD Sort";
            this.RadixLSDSortButton.UseVisualStyleBackColor = true;
            this.RadixLSDSortButton.Click += new System.EventHandler(this.RadixLSDSortButton_Click);
            // 
            // MergeSortButton
            // 
            this.MergeSortButton.Location = new System.Drawing.Point(317, 87);
            this.MergeSortButton.Name = "MergeSortButton";
            this.MergeSortButton.Size = new System.Drawing.Size(85, 23);
            this.MergeSortButton.TabIndex = 12;
            this.MergeSortButton.Text = "MergeSort";
            this.MergeSortButton.UseVisualStyleBackColor = true;
            this.MergeSortButton.Click += new System.EventHandler(this.MergeSortButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(317, 58);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(85, 23);
            this.TreeSortButton.TabIndex = 11;
            this.TreeSortButton.Text = "TreeSort";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click_1);
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(317, 29);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(85, 23);
            this.GnomeSortButton.TabIndex = 10;
            this.GnomeSortButton.Text = "GnomeSort";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(226, 86);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(85, 23);
            this.HeapSortButton.TabIndex = 9;
            this.HeapSortButton.Text = "HeapSort";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // SelectionSortButton
            // 
            this.SelectionSortButton.Location = new System.Drawing.Point(226, 28);
            this.SelectionSortButton.Name = "SelectionSortButton";
            this.SelectionSortButton.Size = new System.Drawing.Size(85, 23);
            this.SelectionSortButton.TabIndex = 8;
            this.SelectionSortButton.Text = "SelectionSort";
            this.SelectionSortButton.UseVisualStyleBackColor = true;
            this.SelectionSortButton.Click += new System.EventHandler(this.SelectionSortButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.Location = new System.Drawing.Point(226, 57);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(85, 23);
            this.ShellSortButton.TabIndex = 7;
            this.ShellSortButton.Text = "ShellSort";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Location = new System.Drawing.Point(135, 86);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(85, 23);
            this.InsertSortButton.TabIndex = 6;
            this.InsertSortButton.Text = "InsertSort";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // CocktailSortButton
            // 
            this.CocktailSortButton.Location = new System.Drawing.Point(135, 57);
            this.CocktailSortButton.Name = "CocktailSortButton";
            this.CocktailSortButton.Size = new System.Drawing.Size(85, 23);
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
            this.BubbleSortButton.Location = new System.Drawing.Point(135, 28);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(85, 23);
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
            // DangerousGroup
            // 
            this.DangerousGroup.Controls.Add(this.BogoSortButton);
            this.DangerousGroup.ForeColor = System.Drawing.Color.DarkRed;
            this.DangerousGroup.Location = new System.Drawing.Point(499, 12);
            this.DangerousGroup.Name = "DangerousGroup";
            this.DangerousGroup.Size = new System.Drawing.Size(107, 100);
            this.DangerousGroup.TabIndex = 0;
            this.DangerousGroup.TabStop = false;
            this.DangerousGroup.Text = "Dangerous zone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 302);
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
            this.DangerousGroup.ResumeLayout(false);
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
        private System.Windows.Forms.Button ShellSortButton;
        private System.Windows.Forms.Button SelectionSortButton;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.Button GnomeSortButton;
        private System.Windows.Forms.Button TreeSortButton;
        private System.Windows.Forms.Button MergeSortButton;
        private System.Windows.Forms.Button RadixMSDSortButton;
        private System.Windows.Forms.Button RadixLSDSortButton;
        private System.Windows.Forms.Button QuickSortButton;
        private System.Windows.Forms.Button BogoSortButton;
        private System.Windows.Forms.GroupBox DangerousGroup;
    }
}

