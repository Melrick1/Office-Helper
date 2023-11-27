namespace Student_Helper
{
    partial class FormAdmin
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ShowCheck1 = new System.Windows.Forms.CheckBox();
            this.ErrorMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.buttonCrystal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(141, 114);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(92, 38);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(253, 114);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(92, 38);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(28, 114);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 38);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Insert";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 199);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(907, 476);
            this.dataGridView1.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.buttonCrystal);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.ShowCheck1);
            this.panel1.Controls.Add(this.ErrorMsg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PassBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmailBox);
            this.panel1.Controls.Add(this.UserBox);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 167);
            this.panel1.TabIndex = 29;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Gold;
            this.ExitBtn.Location = new System.Drawing.Point(831, 114);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(92, 38);
            this.ExitBtn.TabIndex = 42;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ShowCheck1
            // 
            this.ShowCheck1.AutoSize = true;
            this.ShowCheck1.ForeColor = System.Drawing.Color.White;
            this.ShowCheck1.Location = new System.Drawing.Point(788, 54);
            this.ShowCheck1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowCheck1.Name = "ShowCheck1";
            this.ShowCheck1.Size = new System.Drawing.Size(62, 20);
            this.ShowCheck1.TabIndex = 41;
            this.ShowCheck1.Text = "Show";
            this.ShowCheck1.UseVisualStyleBackColor = true;
            this.ShowCheck1.CheckedChanged += new System.EventHandler(this.ShowCheck1_CheckedChanged);
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsg.Location = new System.Drawing.Point(27, 86);
            this.ErrorMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(50, 18);
            this.ErrorMsg.TabIndex = 40;
            this.ErrorMsg.Text = "Error :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(543, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Password";
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.Location = new System.Drawing.Point(547, 46);
            this.PassBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(232, 30);
            this.PassBox.TabIndex = 32;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Username";
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(288, 46);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(232, 30);
            this.EmailBox.TabIndex = 29;
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.Location = new System.Drawing.Point(28, 46);
            this.UserBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(232, 30);
            this.UserBox.TabIndex = 28;
            // 
            // buttonCrystal
            // 
            this.buttonCrystal.Location = new System.Drawing.Point(668, 114);
            this.buttonCrystal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrystal.Name = "buttonCrystal";
            this.buttonCrystal.Size = new System.Drawing.Size(111, 38);
            this.buttonCrystal.TabIndex = 43;
            this.buttonCrystal.Text = "Crystal Report";
            this.buttonCrystal.UseVisualStyleBackColor = true;
            this.buttonCrystal.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 690);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorMsg;
        private System.Windows.Forms.CheckBox ShowCheck1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button buttonCrystal;
    }
}