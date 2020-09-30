namespace ACCOUNTINGNADIM
{
    partial class frmItemSL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemSL));
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPriview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioRanged = new System.Windows.Forms.RadioButton();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.txtLI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("SutonnyMJ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.Magenta;
            this.txtA.Location = new System.Drawing.Point(421, 52);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(307, 27);
            this.txtA.TabIndex = 504;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(505, 155);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 33);
            this.btnExit.TabIndex = 502;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(328, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 500;
            this.label5.Text = "Ledger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(-1, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 507;
            this.label4.Text = "Groups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(328, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 505;
            this.label3.Text = "Address";
            // 
            // btnPriview
            // 
            this.btnPriview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPriview.BackgroundImage")));
            this.btnPriview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriview.ForeColor = System.Drawing.Color.Green;
            this.btnPriview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPriview.Location = new System.Drawing.Point(375, 131);
            this.btnPriview.Name = "btnPriview";
            this.btnPriview.Size = new System.Drawing.Size(77, 80);
            this.btnPriview.TabIndex = 501;
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
            this.label2.Location = new System.Drawing.Point(59, 140);
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
            this.label1.Location = new System.Drawing.Point(80, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 350;
            this.label1.Text = "To";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.BackColor = System.Drawing.Color.Gray;
            this.radioAll.Checked = true;
            this.radioAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAll.ForeColor = System.Drawing.Color.Yellow;
            this.radioAll.Location = new System.Drawing.Point(81, 92);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(52, 28);
            this.radioAll.TabIndex = 68;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = false;
            // 
            // radioRanged
            // 
            this.radioRanged.AutoSize = true;
            this.radioRanged.BackColor = System.Drawing.Color.Gray;
            this.radioRanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRanged.ForeColor = System.Drawing.Color.Yellow;
            this.radioRanged.Location = new System.Drawing.Point(166, 92);
            this.radioRanged.Name = "radioRanged";
            this.radioRanged.Size = new System.Drawing.Size(101, 28);
            this.radioRanged.TabIndex = 67;
            this.radioRanged.Text = "Ranged";
            this.radioRanged.UseVisualStyleBackColor = false;
            // 
            // To
            // 
            this.To.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.To.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.To.CustomFormat = "dd/MMM/yyyy";
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To.Location = new System.Drawing.Point(142, 181);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(214, 35);
            this.To.TabIndex = 407;
            // 
            // From
            // 
            this.From.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.From.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.From.CustomFormat = "dd/MMM/yyyy";
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From.Location = new System.Drawing.Point(142, 131);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(214, 35);
            this.From.TabIndex = 408;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("SutonnyMJ", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(13, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 523;
            this.label7.Text = "cY¨";
            // 
            // cmbGroups
            // 
            this.cmbGroups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGroups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cmbGroups.Font = new System.Drawing.Font("SutonnyMJ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroups.ForeColor = System.Drawing.Color.Magenta;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGroups.Location = new System.Drawing.Point(81, 10);
            this.cmbGroups.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(242, 33);
            this.cmbGroups.TabIndex = 524;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.Font = new System.Drawing.Font("SutonnyMJ", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItem.ForeColor = System.Drawing.Color.Magenta;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(81, 50);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(242, 31);
            this.cmbItem.TabIndex = 526;
            // 
            // cmbName
            // 
            this.cmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbName.Font = new System.Drawing.Font("SutonnyMJ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.ForeColor = System.Drawing.Color.Magenta;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbName.Location = new System.Drawing.Point(421, 4);
            this.cmbName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(307, 33);
            this.cmbName.TabIndex = 525;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged_1);
            this.cmbName.SelectedValueChanged += new System.EventHandler(this.cmbName_SelectedValueChanged);
            // 
            // txtLI
            // 
            this.txtLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLI.ForeColor = System.Drawing.Color.Magenta;
            this.txtLI.HideSelection = false;
            this.txtLI.Location = new System.Drawing.Point(421, 92);
            this.txtLI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLI.Multiline = true;
            this.txtLI.Name = "txtLI";
            this.txtLI.Size = new System.Drawing.Size(124, 28);
            this.txtLI.TabIndex = 556;
            // 
            // frmItemSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 245);
            this.Controls.Add(this.txtLI);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.From);
            this.Controls.Add(this.To);
            this.Controls.Add(this.radioRanged);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPriview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemSL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Sub Ledger";
            this.Load += new System.EventHandler(this.frmItemSL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPriview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioRanged;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.TextBox txtLI;
    }
}