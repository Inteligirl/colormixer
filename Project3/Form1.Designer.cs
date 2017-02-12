namespace Project3
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
            this.firstColor = new System.Windows.Forms.GroupBox();
            this.secondColor = new System.Windows.Forms.GroupBox();
            this.firstRed = new System.Windows.Forms.RadioButton();
            this.firstBlue = new System.Windows.Forms.RadioButton();
            this.firstYellow = new System.Windows.Forms.RadioButton();
            this.secondRed = new System.Windows.Forms.RadioButton();
            this.secondBlue = new System.Windows.Forms.RadioButton();
            this.secondYellow = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstColor.SuspendLayout();
            this.secondColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstColor
            // 
            this.firstColor.Controls.Add(this.firstBlue);
            this.firstColor.Controls.Add(this.firstYellow);
            this.firstColor.Controls.Add(this.firstRed);
            this.firstColor.Location = new System.Drawing.Point(32, 30);
            this.firstColor.Name = "firstColor";
            this.firstColor.Size = new System.Drawing.Size(149, 139);
            this.firstColor.TabIndex = 0;
            this.firstColor.TabStop = false;
            this.firstColor.Text = "Select the First Color";
            // 
            // secondColor
            // 
            this.secondColor.Controls.Add(this.secondYellow);
            this.secondColor.Controls.Add(this.secondBlue);
            this.secondColor.Controls.Add(this.secondRed);
            this.secondColor.Location = new System.Drawing.Point(206, 30);
            this.secondColor.Name = "secondColor";
            this.secondColor.Size = new System.Drawing.Size(150, 140);
            this.secondColor.TabIndex = 1;
            this.secondColor.TabStop = false;
            this.secondColor.Text = "Select the Second Color";
            // 
            // firstRed
            // 
            this.firstRed.AutoSize = true;
            this.firstRed.Checked = true;
            this.firstRed.Location = new System.Drawing.Point(16, 37);
            this.firstRed.Name = "firstRed";
            this.firstRed.Size = new System.Drawing.Size(45, 17);
            this.firstRed.TabIndex = 0;
            this.firstRed.TabStop = true;
            this.firstRed.Text = "Red";
            this.firstRed.UseVisualStyleBackColor = true;
            
            // 
            // firstBlue
            // 
            this.firstBlue.AutoSize = true;
            this.firstBlue.Location = new System.Drawing.Point(16, 60);
            this.firstBlue.Name = "firstBlue";
            this.firstBlue.Size = new System.Drawing.Size(46, 17);
            this.firstBlue.TabIndex = 2;
            this.firstBlue.Text = "Blue";
            this.firstBlue.UseVisualStyleBackColor = true;
            
            // 
            // firstYellow
            // 
            this.firstYellow.AutoSize = true;
            this.firstYellow.Location = new System.Drawing.Point(16, 83);
            this.firstYellow.Name = "firstYellow";
            this.firstYellow.Size = new System.Drawing.Size(56, 17);
            this.firstYellow.TabIndex = 3;
            this.firstYellow.Text = "Yellow";
            this.firstYellow.UseVisualStyleBackColor = true;
            
            // 
            // secondRed
            // 
            this.secondRed.AutoSize = true;
            this.secondRed.Checked = true;
            this.secondRed.Location = new System.Drawing.Point(11, 37);
            this.secondRed.Name = "secondRed";
            this.secondRed.Size = new System.Drawing.Size(45, 17);
            this.secondRed.TabIndex = 0;
            this.secondRed.TabStop = true;
            this.secondRed.Text = "Red";
            this.secondRed.UseVisualStyleBackColor = true;
            
            // 
            // secondBlue
            // 
            this.secondBlue.AutoSize = true;
            this.secondBlue.Location = new System.Drawing.Point(11, 60);
            this.secondBlue.Name = "secondBlue";
            this.secondBlue.Size = new System.Drawing.Size(46, 17);
            this.secondBlue.TabIndex = 1;
            this.secondBlue.Text = "Blue";
            this.secondBlue.UseVisualStyleBackColor = true;
            
            // 
            // secondYellow
            // 
            this.secondYellow.AutoSize = true;
            this.secondYellow.Location = new System.Drawing.Point(11, 83);
            this.secondYellow.Name = "secondYellow";
            this.secondYellow.Size = new System.Drawing.Size(56, 17);
            this.secondYellow.TabIndex = 2;
            this.secondYellow.Text = "Yellow";
            this.secondYellow.UseVisualStyleBackColor = true;
            
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(125, 202);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(75, 23);
            this.mixButton.TabIndex = 2;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(206, 202);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 264);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.secondColor);
            this.Controls.Add(this.firstColor);
            this.Name = "Form1";
            this.Text = "Project 3 Color Mixer";
            this.firstColor.ResumeLayout(false);
            this.firstColor.PerformLayout();
            this.secondColor.ResumeLayout(false);
            this.secondColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox firstColor;
        private System.Windows.Forms.RadioButton firstBlue;
        private System.Windows.Forms.RadioButton firstYellow;
        private System.Windows.Forms.RadioButton firstRed;
        private System.Windows.Forms.GroupBox secondColor;
        private System.Windows.Forms.RadioButton secondYellow;
        private System.Windows.Forms.RadioButton secondBlue;
        private System.Windows.Forms.RadioButton secondRed;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

