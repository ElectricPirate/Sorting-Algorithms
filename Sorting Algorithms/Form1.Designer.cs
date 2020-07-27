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
            this.AddNumbersPanel.SuspendLayout();
            this.FillRandomPanel.SuspendLayout();
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
            this.AddNumbersPanel.Size = new System.Drawing.Size(388, 70);
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
            this.AddButton.Location = new System.Drawing.Point(287, 28);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 27);
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
            this.AddTextBox.Size = new System.Drawing.Size(265, 23);
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
            this.FillRandomPanel.Size = new System.Drawing.Size(388, 70);
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
            this.FillRandomButton.Location = new System.Drawing.Point(287, 28);
            this.FillRandomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FillRandomButton.Name = "FillRandomButton";
            this.FillRandomButton.Size = new System.Drawing.Size(88, 27);
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
            this.AmountRandomTextBox.Size = new System.Drawing.Size(265, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.VisualizationPanel);
            this.Controls.Add(this.FillRandomPanel);
            this.Controls.Add(this.AddNumbersPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AddNumbersPanel.ResumeLayout(false);
            this.AddNumbersPanel.PerformLayout();
            this.FillRandomPanel.ResumeLayout(false);
            this.FillRandomPanel.PerformLayout();
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
    }
}

