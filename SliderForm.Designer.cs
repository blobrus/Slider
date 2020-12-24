namespace Slider
{
    partial class SliderForm
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
            this.StepText = new System.Windows.Forms.TextBox();
            this.ClueLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StepText
            // 
            this.StepText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StepText.Location = new System.Drawing.Point(31, 25);
            this.StepText.Name = "StepText";
            this.StepText.Size = new System.Drawing.Size(162, 20);
            this.StepText.TabIndex = 0;
            // 
            // ClueLabel
            // 
            this.ClueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClueLabel.AutoSize = true;
            this.ClueLabel.Location = new System.Drawing.Point(52, 9);
            this.ClueLabel.Name = "ClueLabel";
            this.ClueLabel.Size = new System.Drawing.Size(113, 13);
            this.ClueLabel.TabIndex = 1;
            this.ClueLabel.Text = "Enter Clue Instructions";
            this.ClueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Location = new System.Drawing.Point(67, 51);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(80, 25);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start (F9)";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopButton.Location = new System.Drawing.Point(67, 82);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(80, 25);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop (F10)";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetButton.Location = new System.Drawing.Point(67, 113);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(80, 25);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset (F11)";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // SliderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 165);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ClueLabel);
            this.Controls.Add(this.StepText);
            this.Name = "SliderForm";
            this.Text = "Slider Solver";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StepText;
        private System.Windows.Forms.Label ClueLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

