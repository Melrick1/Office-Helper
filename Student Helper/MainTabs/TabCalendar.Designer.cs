namespace Student_Helper
{
    partial class TabCalendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabCalendar));
            this.labelMonth = new System.Windows.Forms.Label();
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.NextBtn = new System.Windows.Forms.PictureBox();
            this.PrevBtn = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MonthSelector = new System.Windows.Forms.ComboBox();
            this.YearSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevBtn)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMonth
            // 
            this.labelMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Location = new System.Drawing.Point(0, 0);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(1014, 65);
            this.labelMonth.TabIndex = 27;
            this.labelMonth.Text = "Month Year";
            this.labelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayContainer
            // 
            this.dayContainer.BackColor = System.Drawing.Color.Silver;
            this.dayContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayContainer.Location = new System.Drawing.Point(0, 97);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Padding = new System.Windows.Forms.Padding(5);
            this.dayContainer.Size = new System.Drawing.Size(1014, 518);
            this.dayContainer.TabIndex = 17;
            // 
            // NextBtn
            // 
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextBtn.Image")));
            this.NextBtn.Location = new System.Drawing.Point(640, 23);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(20, 20);
            this.NextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextBtn.TabIndex = 28;
            this.NextBtn.TabStop = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrevBtn.Image")));
            this.PrevBtn.Location = new System.Drawing.Point(354, 23);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(20, 20);
            this.PrevBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrevBtn.TabIndex = 29;
            this.PrevBtn.TabStop = false;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(866, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(723, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Friday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Thursday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Wednesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tuesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Monday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1014, 30);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // MonthSelector
            // 
            this.MonthSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthSelector.FormattingEnabled = true;
            this.MonthSelector.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthSelector.Location = new System.Drawing.Point(6, 22);
            this.MonthSelector.Name = "MonthSelector";
            this.MonthSelector.Size = new System.Drawing.Size(138, 24);
            this.MonthSelector.TabIndex = 31;
            this.MonthSelector.Text = "Month";
            this.MonthSelector.SelectedIndexChanged += new System.EventHandler(this.MonthSelector_SelectedIndexChanged);
            // 
            // YearSelector
            // 
            this.YearSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSelector.FormattingEnabled = true;
            this.YearSelector.Location = new System.Drawing.Point(154, 22);
            this.YearSelector.Name = "YearSelector";
            this.YearSelector.Size = new System.Drawing.Size(138, 24);
            this.YearSelector.TabIndex = 32;
            this.YearSelector.Text = "Year";
            this.YearSelector.SelectedIndexChanged += new System.EventHandler(this.YearSelector_SelectedIndexChanged);
            // 
            // TabCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YearSelector);
            this.Controls.Add(this.MonthSelector);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.dayContainer);
            this.Name = "TabCalendar";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.TabCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevBtn)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.FlowLayoutPanel dayContainer;
        private System.Windows.Forms.PictureBox NextBtn;
        private System.Windows.Forms.PictureBox PrevBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox MonthSelector;
        private System.Windows.Forms.ComboBox YearSelector;
    }
}
