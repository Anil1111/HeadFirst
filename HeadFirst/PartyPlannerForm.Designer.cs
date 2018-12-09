namespace HeadFirst
{
    partial class PartyPlannerForm
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
            this.PeopleQuantityLbl = new System.Windows.Forms.Label();
            this.PeopleQuantityNm = new System.Windows.Forms.NumericUpDown();
            this.FantasyDecorationsCb = new System.Windows.Forms.CheckBox();
            this.HealthyOptionCb = new System.Windows.Forms.CheckBox();
            this.CostLbl = new System.Windows.Forms.Label();
            this.CostDisplay = new System.Windows.Forms.Label();
            this.PartyTab = new System.Windows.Forms.TabControl();
            this.Dinner = new System.Windows.Forms.TabPage();
            this.Birthday = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleQuantityNm)).BeginInit();
            this.PartyTab.SuspendLayout();
            this.Dinner.SuspendLayout();
            this.Birthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleQuantityLbl
            // 
            this.PeopleQuantityLbl.AutoSize = true;
            this.PeopleQuantityLbl.Location = new System.Drawing.Point(24, 39);
            this.PeopleQuantityLbl.Name = "PeopleQuantityLbl";
            this.PeopleQuantityLbl.Size = new System.Drawing.Size(98, 13);
            this.PeopleQuantityLbl.TabIndex = 0;
            this.PeopleQuantityLbl.Text = "How many people?";
            // 
            // PeopleQuantityNm
            // 
            this.PeopleQuantityNm.Location = new System.Drawing.Point(147, 37);
            this.PeopleQuantityNm.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PeopleQuantityNm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleQuantityNm.Name = "PeopleQuantityNm";
            this.PeopleQuantityNm.Size = new System.Drawing.Size(95, 20);
            this.PeopleQuantityNm.TabIndex = 1;
            this.PeopleQuantityNm.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PeopleQuantityNm.ValueChanged += new System.EventHandler(this.PeopleQuantityNm_ValueChanged);
            // 
            // FantasyDecorationsCb
            // 
            this.FantasyDecorationsCb.AutoSize = true;
            this.FantasyDecorationsCb.Checked = true;
            this.FantasyDecorationsCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FantasyDecorationsCb.Location = new System.Drawing.Point(66, 82);
            this.FantasyDecorationsCb.Name = "FantasyDecorationsCb";
            this.FantasyDecorationsCb.Size = new System.Drawing.Size(123, 17);
            this.FantasyDecorationsCb.TabIndex = 2;
            this.FantasyDecorationsCb.Text = "Fantasy Decorations";
            this.FantasyDecorationsCb.UseVisualStyleBackColor = true;
            this.FantasyDecorationsCb.CheckedChanged += new System.EventHandler(this.FantasyDecorationsCb_CheckedChanged);
            // 
            // HealthyOptionCb
            // 
            this.HealthyOptionCb.AutoSize = true;
            this.HealthyOptionCb.Location = new System.Drawing.Point(66, 111);
            this.HealthyOptionCb.Name = "HealthyOptionCb";
            this.HealthyOptionCb.Size = new System.Drawing.Size(96, 17);
            this.HealthyOptionCb.TabIndex = 3;
            this.HealthyOptionCb.Text = "Healthy Option";
            this.HealthyOptionCb.UseVisualStyleBackColor = true;
            this.HealthyOptionCb.CheckedChanged += new System.EventHandler(this.HealthyOptionCb_CheckedChanged);
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Location = new System.Drawing.Point(24, 169);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(28, 13);
            this.CostLbl.TabIndex = 4;
            this.CostLbl.Text = "Cost";
            // 
            // CostDisplay
            // 
            this.CostDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CostDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CostDisplay.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CostDisplay.Location = new System.Drawing.Point(71, 157);
            this.CostDisplay.Name = "CostDisplay";
            this.CostDisplay.Size = new System.Drawing.Size(91, 25);
            this.CostDisplay.TabIndex = 5;
            // 
            // PartyTab
            // 
            this.PartyTab.Controls.Add(this.Dinner);
            this.PartyTab.Controls.Add(this.Birthday);
            this.PartyTab.Location = new System.Drawing.Point(-6, 1);
            this.PartyTab.Name = "PartyTab";
            this.PartyTab.SelectedIndex = 0;
            this.PartyTab.Size = new System.Drawing.Size(269, 269);
            this.PartyTab.TabIndex = 6;
            // 
            // Dinner
            // 
            this.Dinner.Controls.Add(this.PeopleQuantityLbl);
            this.Dinner.Controls.Add(this.CostDisplay);
            this.Dinner.Controls.Add(this.PeopleQuantityNm);
            this.Dinner.Controls.Add(this.CostLbl);
            this.Dinner.Controls.Add(this.FantasyDecorationsCb);
            this.Dinner.Controls.Add(this.HealthyOptionCb);
            this.Dinner.Location = new System.Drawing.Point(4, 22);
            this.Dinner.Name = "Dinner";
            this.Dinner.Padding = new System.Windows.Forms.Padding(3);
            this.Dinner.Size = new System.Drawing.Size(261, 243);
            this.Dinner.TabIndex = 0;
            this.Dinner.Text = "Dinner";
            this.Dinner.UseVisualStyleBackColor = true;
            // 
            // Birthday
            // 
            this.Birthday.Controls.Add(this.cakeWriting);
            this.Birthday.Controls.Add(this.tooLongLabel);
            this.Birthday.Controls.Add(this.label4);
            this.Birthday.Controls.Add(this.label1);
            this.Birthday.Controls.Add(this.birthdayCost);
            this.Birthday.Controls.Add(this.numberBirthday);
            this.Birthday.Controls.Add(this.label3);
            this.Birthday.Controls.Add(this.fancyBirthday);
            this.Birthday.Location = new System.Drawing.Point(4, 22);
            this.Birthday.Name = "Birthday";
            this.Birthday.Padding = new System.Windows.Forms.Padding(3);
            this.Birthday.Size = new System.Drawing.Size(261, 243);
            this.Birthday.TabIndex = 1;
            this.Birthday.Text = "Birthday";
            this.Birthday.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "How many people?";
            // 
            // birthdayCost
            // 
            this.birthdayCost.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.birthdayCost.Location = new System.Drawing.Point(24, 159);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(91, 25);
            this.birthdayCost.TabIndex = 11;
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(144, 37);
            this.numberBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(95, 20);
            this.numberBirthday.TabIndex = 7;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Checked = true;
            this.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthday.Location = new System.Drawing.Point(24, 63);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(123, 17);
            this.fancyBirthday.TabIndex = 8;
            this.fancyBirthday.Text = "Fantasy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cake writing";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.DarkRed;
            this.tooLongLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tooLongLabel.Location = new System.Drawing.Point(100, 97);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 13;
            this.tooLongLabel.Text = "TOO LONG";
            this.tooLongLabel.Visible = false;
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(24, 113);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(100, 20);
            this.cakeWriting.TabIndex = 14;
            this.cakeWriting.Text = "Happy Birthday!";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // PartyPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 273);
            this.Controls.Add(this.PartyTab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartyPlannerForm";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleQuantityNm)).EndInit();
            this.PartyTab.ResumeLayout(false);
            this.Dinner.ResumeLayout(false);
            this.Dinner.PerformLayout();
            this.Birthday.ResumeLayout(false);
            this.Birthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PeopleQuantityLbl;
        private System.Windows.Forms.NumericUpDown PeopleQuantityNm;
        private System.Windows.Forms.CheckBox FantasyDecorationsCb;
        private System.Windows.Forms.CheckBox HealthyOptionCb;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label CostDisplay;
        private System.Windows.Forms.TabControl PartyTab;
        private System.Windows.Forms.TabPage Dinner;
        private System.Windows.Forms.TabPage Birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label4;
    }
}

