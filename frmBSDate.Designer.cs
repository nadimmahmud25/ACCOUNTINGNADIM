namespace ACCOUNTINGNADIM
{
    partial class frmBSDate
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
            this.radioRanged = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPriview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // radioRanged
            // 
            this.radioRanged.AutoSize = true;
            this.radioRanged.BackColor = System.Drawing.Color.Gray;
            this.radioRanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRanged.ForeColor = System.Drawing.Color.Yellow;
            this.radioRanged.Location = new System.Drawing.Point(5, 50);
            this.radioRanged.Name = "radioRanged";
            this.radioRanged.Size = new System.Drawing.Size(86, 28);
            this.radioRanged.TabIndex = 507;
            this.radioRanged.TabStop = true;
            this.radioRanged.Text = "Group";
            this.radioRanged.UseVisualStyleBackColor = false;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.BackColor = System.Drawing.Color.Gray;
            this.radioAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAll.ForeColor = System.Drawing.Color.Yellow;
            this.radioAll.Location = new System.Drawing.Point(12, 12);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(52, 28);
            this.radioAll.TabIndex = 508;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = false;
            // 
            // cmbGroups
            // 
            this.cmbGroups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGroups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cmbGroups.Font = new System.Drawing.Font("SutonnyMJ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroups.ForeColor = System.Drawing.Color.Magenta;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGroups.Location = new System.Drawing.Point(96, 50);
            this.cmbGroups.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(255, 26);
            this.cmbGroups.TabIndex = 505;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(334, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 33);
            this.btnExit.TabIndex = 504;
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
            this.btnPriview.Location = new System.Drawing.Point(334, 83);
            this.btnPriview.Name = "btnPriview";
            this.btnPriview.Size = new System.Drawing.Size(77, 80);
            this.btnPriview.TabIndex = 503;
            this.btnPriview.UseVisualStyleBackColor = true;
            this.btnPriview.Click += new System.EventHandler(this.btnPriview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 349;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(27, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 350;
            this.label1.Text = "To";
            // 
            // To
            // 
            this.To.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.To.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.To.CustomFormat = "dd/MMM/yyyy";
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To.Location = new System.Drawing.Point(70, 150);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(227, 35);
            this.To.TabIndex = 407;
            // 
            // From
            // 
            this.From.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.From.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.From.CustomFormat = "dd/MMM/yyyy";
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From.Location = new System.Drawing.Point(70, 100);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(227, 35);
            this.From.TabIndex = 408;
            // 
            // frmBSDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 233);
            this.Controls.Add(this.From);
            this.Controls.Add(this.To);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioRanged);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPriview);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBSDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BSDate";
            this.Load += new System.EventHandler(this.frmBSDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioRanged;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPriview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.DateTimePicker From;
    }
}