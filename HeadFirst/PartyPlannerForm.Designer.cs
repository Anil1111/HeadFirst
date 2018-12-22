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
            this.LabelNumberOfPeople = new System.Windows.Forms.Label();
            this.NumericUpDownNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxFantasyDecorations = new System.Windows.Forms.CheckBox();
            this.CheckBoxHealthyOption = new System.Windows.Forms.CheckBox();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelCostDisplay = new System.Windows.Forms.Label();
            this.PartyTab = new System.Windows.Forms.TabControl();
            this.Dinner = new System.Windows.Forms.TabPage();
            this.Birthday = new System.Windows.Forms.TabPage();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.BirthdayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberOfPeople)).BeginInit();
            this.PartyTab.SuspendLayout();
            this.Dinner.SuspendLayout();
            this.Birthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNumberOfPeople
            // 
            this.LabelNumberOfPeople.AutoSize = true;
            this.LabelNumberOfPeople.Location = new System.Drawing.Point(24, 39);
            this.LabelNumberOfPeople.Name = "LabelNumberOfPeople";
            this.LabelNumberOfPeople.Size = new System.Drawing.Size(98, 13);
            this.LabelNumberOfPeople.TabIndex = 0;
            this.LabelNumberOfPeople.Text = "How many people?";
            // 
            // NumericUpDownNumberOfPeople
            // 
            this.NumericUpDownNumberOfPeople.Location = new System.Drawing.Point(147, 37);
            this.NumericUpDownNumberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericUpDownNumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownNumberOfPeople.Name = "NumericUpDownNumberOfPeople";
            this.NumericUpDownNumberOfPeople.Size = new System.Drawing.Size(95, 20);
            this.NumericUpDownNumberOfPeople.TabIndex = 1;
            this.NumericUpDownNumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownNumberOfPeople.ValueChanged += new System.EventHandler(this.NumericUpDownNumberOfPeople_ValueChanged);
            // 
            // CheckBoxFantasyDecorations
            // 
            this.CheckBoxFantasyDecorations.AutoSize = true;
            this.CheckBoxFantasyDecorations.Checked = true;
            this.CheckBoxFantasyDecorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxFantasyDecorations.Location = new System.Drawing.Point(66, 82);
            this.CheckBoxFantasyDecorations.Name = "CheckBoxFantasyDecorations";
            this.CheckBoxFantasyDecorations.Size = new System.Drawing.Size(123, 17);
            this.CheckBoxFantasyDecorations.TabIndex = 2;
            this.CheckBoxFantasyDecorations.Text = "Fantasy Decorations";
            this.CheckBoxFantasyDecorations.UseVisualStyleBackColor = true;
            this.CheckBoxFantasyDecorations.CheckedChanged += new System.EventHandler(this.FantasyDecorationsCb_CheckedChanged);
            // 
            // CheckBoxHealthyOption
            // 
            this.CheckBoxHealthyOption.AutoSize = true;
            this.CheckBoxHealthyOption.Location = new System.Drawing.Point(66, 111);
            this.CheckBoxHealthyOption.Name = "CheckBoxHealthyOption";
            this.CheckBoxHealthyOption.Size = new System.Drawing.Size(96, 17);
            this.CheckBoxHealthyOption.TabIndex = 3;
            this.CheckBoxHealthyOption.Text = "Healthy Option";
            this.CheckBoxHealthyOption.UseVisualStyleBackColor = true;
            this.CheckBoxHealthyOption.CheckedChanged += new System.EventHandler(this.HealthyOptionCb_CheckedChanged);
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(24, 169);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(28, 13);
            this.LabelCost.TabIndex = 4;
            this.LabelCost.Text = "Cost";
            // 
            // LabelCostDisplay
            // 
            this.LabelCostDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LabelCostDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCostDisplay.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LabelCostDisplay.Location = new System.Drawing.Point(71, 157);
            this.LabelCostDisplay.Name = "LabelCostDisplay";
            this.LabelCostDisplay.Size = new System.Drawing.Size(91, 25);
            this.LabelCostDisplay.TabIndex = 5;
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
            this.Dinner.Controls.Add(this.LabelNumberOfPeople);
            this.Dinner.Controls.Add(this.LabelCostDisplay);
            this.Dinner.Controls.Add(this.NumericUpDownNumberOfPeople);
            this.Dinner.Controls.Add(this.LabelCost);
            this.Dinner.Controls.Add(this.CheckBoxFantasyDecorations);
            this.Dinner.Controls.Add(this.CheckBoxHealthyOption);
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
            this.Birthday.Controls.Add(this.BirthdayNumericUpDown);
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
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(24, 113);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(100, 20);
            this.cakeWriting.TabIndex = 14;
            this.cakeWriting.Text = "Happy Birthday!";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cake writing";
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
            // BirthdayNumericUpDown
            // 
            this.BirthdayNumericUpDown.Location = new System.Drawing.Point(144, 37);
            this.BirthdayNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.BirthdayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BirthdayNumericUpDown.Name = "BirthdayNumericUpDown";
            this.BirthdayNumericUpDown.Size = new System.Drawing.Size(95, 20);
            this.BirthdayNumericUpDown.TabIndex = 7;
            this.BirthdayNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BirthdayNumericUpDown.ValueChanged += new System.EventHandler(this.BirthdayNumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost";
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
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberOfPeople)).EndInit();
            this.PartyTab.ResumeLayout(false);
            this.Dinner.ResumeLayout(false);
            this.Dinner.PerformLayout();
            this.Birthday.ResumeLayout(false);
            this.Birthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelNumberOfPeople;
        private System.Windows.Forms.NumericUpDown NumericUpDownNumberOfPeople;
        private System.Windows.Forms.CheckBox CheckBoxFantasyDecorations;
        private System.Windows.Forms.CheckBox CheckBoxHealthyOption;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelCostDisplay;
        private System.Windows.Forms.TabControl PartyTab;
        private System.Windows.Forms.TabPage Dinner;
        private System.Windows.Forms.TabPage Birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.NumericUpDown BirthdayNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label4;
    }
}

