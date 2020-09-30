namespace ACCOUNTINGNADIM
{
    partial class frmDayBook
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPriview = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioRanged = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(289, 122);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPriview
            // 
            this.btnPriview.BackgroundImage = global::ACCOUNTINGNADIM.Properties.Resources.print;
            this.btnPriview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriview.ForeColor = System.Drawing.Color.Green;
            this.btnPriview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPriview.Location = new System.Drawing.Point(289, 19);
            this.btnPriview.Name = "btnPriview";
            this.btnPriview.Size = new System.Drawing.Size(77, 74);
            this.btnPriview.TabIndex = 9;
            this.btnPriview.UseVisualStyleBackColor = true;
            this.btnPriview.Click += new System.EventHandler(this.btnPriview_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioRanged);
            this.groupBox2.Controls.Add(this.radioAll);
            this.groupBox2.Controls.Add(this.To);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.From);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 178);
            this.groupBox2.TabIndex = 403;
            this.groupBox2.TabStop = false;
            // 
            // radioRanged
            // 
            this.radioRanged.AutoSize = true;
            this.radioRanged.BackColor = System.Drawing.Color.Gray;
            this.radioRanged.Checked = true;
            this.radioRanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRanged.ForeColor = System.Drawing.Color.Yellow;
            this.radioRanged.Location = new System.Drawing.Point(100, 17);
            this.radioRanged.Name = "radioRanged";
            this.radioRanged.Size = new System.Drawing.Size(101, 28);
            this.radioRanged.TabIndex = 352;
            this.radioRanged.TabStop = true;
            this.radioRanged.Text = "Ranged";
            this.radioRanged.UseVisualStyleBackColor = false;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.BackColor = System.Drawing.Color.Gray;
            this.radioAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAll.ForeColor = System.Drawing.Color.Yellow;
            this.radioAll.Location = new System.Drawing.Point(15, 17);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(52, 28);
            this.radioAll.TabIndex = 353;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = false;
            // 
            // To
            // 
            this.To.CalendarForeColor = System.Drawing.Color.Green;
            this.To.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.To.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.To.CustomFormat = "dd/MMM/yyyyy";
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To.Location = new System.Drawing.Point(68, 120);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(177, 29);
            this.To.TabIndex = 351;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 350;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 349;
            this.label2.Text = "From";
            // 
            // From
            // 
            this.From.CalendarForeColor = System.Drawing.Color.Green;
            this.From.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.From.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.From.CustomFormat = "dd/MMM/yyyyy";
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From.Location = new System.Drawing.Point(68, 74);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(177, 29);
            this.From.TabIndex = 348;
            // 
            // frmDayBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPriview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDayBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SHOW CASH BOOK";
            this.Load += new System.EventHandler(this.frmDayBook_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPriview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.RadioButton radioRanged;
        private System.Windows.Forms.RadioButton radioAll;
    }
}