namespace PalindromOrNot
{
    partial class Palindrome
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
            this.btcheck = new System.Windows.Forms.Button();
            this.lbabout = new System.Windows.Forms.Label();
            this.lbpal = new System.Windows.Forms.Label();
            this.tbpal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btcheck
            // 
            this.btcheck.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btcheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcheck.Location = new System.Drawing.Point(350, 177);
            this.btcheck.Name = "btcheck";
            this.btcheck.Size = new System.Drawing.Size(112, 34);
            this.btcheck.TabIndex = 0;
            this.btcheck.Text = "Перевірити";
            this.btcheck.UseVisualStyleBackColor = false;
            this.btcheck.Click += new System.EventHandler(this.btcheck_Click);
            // 
            // lbabout
            // 
            this.lbabout.AutoSize = true;
            this.lbabout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbabout.Location = new System.Drawing.Point(178, 74);
            this.lbabout.Name = "lbabout";
            this.lbabout.Size = new System.Drawing.Size(462, 16);
            this.lbabout.TabIndex = 1;
            this.lbabout.Text = "Введіть слово або речення, яке хочете перевірити на паліндромність:";
            // 
            // lbpal
            // 
            this.lbpal.AutoSize = true;
            this.lbpal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbpal.Location = new System.Drawing.Point(178, 252);
            this.lbpal.Name = "lbpal";
            this.lbpal.Size = new System.Drawing.Size(117, 16);
            this.lbpal.TabIndex = 2;
            this.lbpal.Text = "Паліндром чи ні?";
            // 
            // tbpal
            // 
            this.tbpal.Location = new System.Drawing.Point(181, 120);
            this.tbpal.Name = "tbpal";
            this.tbpal.Size = new System.Drawing.Size(459, 22);
            this.tbpal.TabIndex = 3;
            // 
            // Palindrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbpal);
            this.Controls.Add(this.lbpal);
            this.Controls.Add(this.lbabout);
            this.Controls.Add(this.btcheck);
            this.Name = "Palindrome";
            this.Text = "Palindrome or not?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcheck;
        private System.Windows.Forms.Label lbabout;
        private System.Windows.Forms.Label lbpal;
        private System.Windows.Forms.TextBox tbpal;
    }
}

