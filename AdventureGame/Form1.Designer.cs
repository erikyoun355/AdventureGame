namespace AdventureGame
{
    partial class Form1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.situationLabel = new System.Windows.Forms.Label();
            this.yellowButton = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.Label();
            this.blueButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.PapayaWhip;
            this.outputLabel.Location = new System.Drawing.Point(13, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(319, 260);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Click yellow to start.";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.Teal;
            this.blueLabel.Location = new System.Drawing.Point(16, 383);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blueLabel.Size = new System.Drawing.Size(238, 46);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.redLabel.Location = new System.Drawing.Point(382, 383);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(254, 45);
            this.redLabel.TabIndex = 5;
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yellowLabel
            // 
            this.yellowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.ForeColor = System.Drawing.Color.Gold;
            this.yellowLabel.Location = new System.Drawing.Point(160, 307);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(310, 21);
            this.yellowLabel.TabIndex = 6;
            this.yellowLabel.Text = "Hit me.";
            this.yellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // situationLabel
            // 
            this.situationLabel.BackColor = System.Drawing.Color.Transparent;
            this.situationLabel.ForeColor = System.Drawing.Color.Transparent;
            this.situationLabel.Location = new System.Drawing.Point(338, -1);
            this.situationLabel.Name = "situationLabel";
            this.situationLabel.Size = new System.Drawing.Size(311, 270);
            this.situationLabel.TabIndex = 9;
            // 
            // yellowButton
            // 
            this.yellowButton.Image = global::AdventureGame.Properties.Resources.yellow_50x50;
            this.yellowButton.Location = new System.Drawing.Point(295, 341);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(41, 42);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // redButton
            // 
            this.redButton.Image = global::AdventureGame.Properties.Resources.red_50x50;
            this.redButton.Location = new System.Drawing.Point(324, 383);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(52, 45);
            this.redButton.TabIndex = 2;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Image = global::AdventureGame.Properties.Resources.blue_50x50;
            this.blueButton.Location = new System.Drawing.Point(260, 383);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(42, 42);
            this.blueButton.TabIndex = 1;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(648, 466);
            this.Controls.Add(this.situationLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Forest of Illusions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label blueButton;
        private System.Windows.Forms.Label redButton;
        private System.Windows.Forms.Label yellowButton;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label situationLabel;
    }
}

