namespace Student_Helper
{
    partial class FormSignup
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
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.ShowCheck1 = new System.Windows.Forms.CheckBox();
            this.loginLogo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowCheck2 = new System.Windows.Forms.CheckBox();
            this.ErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.Location = new System.Drawing.Point(456, 271);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(116, 38);
            this.SignUpBtn.TabIndex = 32;
            this.SignUpBtn.Text = "Confirm";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ShowCheck1
            // 
            this.ShowCheck1.AutoSize = true;
            this.ShowCheck1.Location = new System.Drawing.Point(47, 231);
            this.ShowCheck1.Name = "ShowCheck1";
            this.ShowCheck1.Size = new System.Drawing.Size(53, 17);
            this.ShowCheck1.TabIndex = 30;
            this.ShowCheck1.Text = "Show";
            this.ShowCheck1.UseVisualStyleBackColor = true;
            this.ShowCheck1.CheckedChanged += new System.EventHandler(this.ShowCheck1_CheckedChanged);
            // 
            // loginLogo
            // 
            this.loginLogo.BackColor = System.Drawing.Color.Indigo;
            this.loginLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLogo.ForeColor = System.Drawing.Color.White;
            this.loginLogo.Location = new System.Drawing.Point(0, 0);
            this.loginLogo.Name = "loginLogo";
            this.loginLogo.Size = new System.Drawing.Size(584, 71);
            this.loginLogo.TabIndex = 29;
            this.loginLogo.Text = "Sign-up";
            this.loginLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Username";
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(306, 111);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(237, 31);
            this.EmailBox.TabIndex = 26;
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.Location = new System.Drawing.Point(47, 111);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(237, 31);
            this.UserBox.TabIndex = 25;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(334, 271);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(116, 38);
            this.CancelBtn.TabIndex = 24;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(303, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Email";
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.Location = new System.Drawing.Point(47, 194);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(237, 31);
            this.PassBox.TabIndex = 34;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // ConfirmPassBox
            // 
            this.ConfirmPassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConfirmPassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassBox.Location = new System.Drawing.Point(306, 194);
            this.ConfirmPassBox.Name = "ConfirmPassBox";
            this.ConfirmPassBox.Size = new System.Drawing.Size(237, 31);
            this.ConfirmPassBox.TabIndex = 35;
            this.ConfirmPassBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(303, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Confirm Password";
            // 
            // ShowCheck2
            // 
            this.ShowCheck2.AutoSize = true;
            this.ShowCheck2.Location = new System.Drawing.Point(306, 231);
            this.ShowCheck2.Name = "ShowCheck2";
            this.ShowCheck2.Size = new System.Drawing.Size(53, 17);
            this.ShowCheck2.TabIndex = 37;
            this.ShowCheck2.Text = "Show";
            this.ShowCheck2.UseVisualStyleBackColor = true;
            this.ShowCheck2.CheckedChanged += new System.EventHandler(this.ShowCheck2_CheckedChanged);
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsg.Location = new System.Drawing.Point(46, 271);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(40, 15);
            this.ErrorMsg.TabIndex = 38;
            this.ErrorMsg.Text = "Error :";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.ErrorMsg);
            this.Controls.Add(this.ShowCheck2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmPassBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.ShowCheck1);
            this.Controls.Add(this.loginLogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.CancelBtn);
            this.Name = "Signup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.CheckBox ShowCheck1;
        private System.Windows.Forms.Label loginLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox ConfirmPassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ShowCheck2;
        private System.Windows.Forms.Label ErrorMsg;
    }
}