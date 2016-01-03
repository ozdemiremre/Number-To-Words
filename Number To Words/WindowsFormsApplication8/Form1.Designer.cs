namespace WindowsFormsApplication8
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
            this.numLabel = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(12, 38);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(84, 13);
            this.numLabel.TabIndex = 0;
            this.numLabel.Text = "Enter a Number.";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(12, 15);
            this.numBox.MaxLength = 6;
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(101, 20);
            this.numBox.TabIndex = 1;
            this.numBox.TextChanged += new System.EventHandler(this.numBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 94);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.numLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.TextBox numBox;
    }
}

