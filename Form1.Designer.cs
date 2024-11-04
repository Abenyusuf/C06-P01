namespace C06_P01
{
    partial class CostCalculator
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CostCheckButton = new System.Windows.Forms.Button();
            this.MarkupCheckButton = new System.Windows.Forms.Button();
            this.CostCheckLabel = new System.Windows.Forms.Label();
            this.MarkupCheckLabel = new System.Windows.Forms.Label();
            this.WholesaleCostTextLabel = new System.Windows.Forms.Label();
            this.MarkupTextLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.WholsaleCostTextbox = new System.Windows.Forms.TextBox();
            this.MarkupTextbox = new System.Windows.Forms.TextBox();
            this.Percentlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(19, 197);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(91, 37);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(139, 274);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 37);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CostCheckButton
            // 
            this.CostCheckButton.Location = new System.Drawing.Point(261, 69);
            this.CostCheckButton.Name = "CostCheckButton";
            this.CostCheckButton.Size = new System.Drawing.Size(91, 49);
            this.CostCheckButton.TabIndex = 6;
            this.CostCheckButton.Text = "Cost Check";
            this.CostCheckButton.UseVisualStyleBackColor = true;
            this.CostCheckButton.Click += new System.EventHandler(this.CostCheckButton_Click);
            // 
            // MarkupCheckButton
            // 
            this.MarkupCheckButton.Location = new System.Drawing.Point(261, 185);
            this.MarkupCheckButton.Name = "MarkupCheckButton";
            this.MarkupCheckButton.Size = new System.Drawing.Size(91, 49);
            this.MarkupCheckButton.TabIndex = 7;
            this.MarkupCheckButton.Text = "Markup Check";
            this.MarkupCheckButton.UseVisualStyleBackColor = true;
            this.MarkupCheckButton.Click += new System.EventHandler(this.MarkupCheckButton_Click);
            // 
            // CostCheckLabel
            // 
            this.CostCheckLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CostCheckLabel.Location = new System.Drawing.Point(221, 9);
            this.CostCheckLabel.Name = "CostCheckLabel";
            this.CostCheckLabel.Size = new System.Drawing.Size(131, 57);
            this.CostCheckLabel.TabIndex = 8;
            // 
            // MarkupCheckLabel
            // 
            this.MarkupCheckLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MarkupCheckLabel.Location = new System.Drawing.Point(221, 126);
            this.MarkupCheckLabel.Name = "MarkupCheckLabel";
            this.MarkupCheckLabel.Size = new System.Drawing.Size(131, 56);
            this.MarkupCheckLabel.TabIndex = 9;
            // 
            // WholesaleCostTextLabel
            // 
            this.WholesaleCostTextLabel.AutoSize = true;
            this.WholesaleCostTextLabel.Location = new System.Drawing.Point(15, 38);
            this.WholesaleCostTextLabel.Name = "WholesaleCostTextLabel";
            this.WholesaleCostTextLabel.Size = new System.Drawing.Size(120, 20);
            this.WholesaleCostTextLabel.TabIndex = 11;
            this.WholesaleCostTextLabel.Text = "Wholesale Cost";
            // 
            // MarkupTextLabel
            // 
            this.MarkupTextLabel.AutoSize = true;
            this.MarkupTextLabel.Location = new System.Drawing.Point(15, 98);
            this.MarkupTextLabel.Name = "MarkupTextLabel";
            this.MarkupTextLabel.Size = new System.Drawing.Size(157, 20);
            this.MarkupTextLabel.TabIndex = 12;
            this.MarkupTextLabel.Text = "Markup As a Percent";
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Location = new System.Drawing.Point(134, 205);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(100, 23);
            this.OutputLabel.TabIndex = 13;
            // 
            // WholsaleCostTextbox
            // 
            this.WholsaleCostTextbox.Location = new System.Drawing.Point(19, 61);
            this.WholsaleCostTextbox.Name = "WholsaleCostTextbox";
            this.WholsaleCostTextbox.Size = new System.Drawing.Size(100, 26);
            this.WholsaleCostTextbox.TabIndex = 14;
            // 
            // MarkupTextbox
            // 
            this.MarkupTextbox.Location = new System.Drawing.Point(19, 138);
            this.MarkupTextbox.Name = "MarkupTextbox";
            this.MarkupTextbox.Size = new System.Drawing.Size(100, 26);
            this.MarkupTextbox.TabIndex = 15;
            // 
            // Percentlabel
            // 
            this.Percentlabel.AutoSize = true;
            this.Percentlabel.Location = new System.Drawing.Point(125, 144);
            this.Percentlabel.Name = "Percentlabel";
            this.Percentlabel.Size = new System.Drawing.Size(23, 20);
            this.Percentlabel.TabIndex = 16;
            this.Percentlabel.Text = "%";
            // 
            // CostCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 323);
            this.Controls.Add(this.Percentlabel);
            this.Controls.Add(this.MarkupTextbox);
            this.Controls.Add(this.WholsaleCostTextbox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.MarkupTextLabel);
            this.Controls.Add(this.WholesaleCostTextLabel);
            this.Controls.Add(this.MarkupCheckLabel);
            this.Controls.Add(this.CostCheckLabel);
            this.Controls.Add(this.MarkupCheckButton);
            this.Controls.Add(this.CostCheckButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Name = "CostCalculator";
            this.Text = "Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CostCheckButton;
        private System.Windows.Forms.Button MarkupCheckButton;
        private System.Windows.Forms.Label CostCheckLabel;
        private System.Windows.Forms.Label MarkupCheckLabel;
        private System.Windows.Forms.Label WholesaleCostTextLabel;
        private System.Windows.Forms.Label MarkupTextLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox WholsaleCostTextbox;
        private System.Windows.Forms.TextBox MarkupTextbox;
        private System.Windows.Forms.Label Percentlabel;
    }
}

