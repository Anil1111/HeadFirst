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
            this.CheckBoxFancyDecorations = new System.Windows.Forms.CheckBox();
            this.CheckBoxHealthyOption = new System.Windows.Forms.CheckBox();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelCostDisplay = new System.Windows.Forms.Label();
            this.PartyTab = new System.Windows.Forms.TabControl();
            this.Dinner = new System.Windows.Forms.TabPage();
            this.Birthday = new System.Windows.Forms.TabPage();
            this.TextBoxCakeWriting = new System.Windows.Forms.TextBox();
            this.LabelWritingTooLong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCostDisplayBD = new System.Windows.Forms.Label();
            this.NumericUpDownNumberOfPeopleBD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxFancyDecorationsBD = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberOfPeople)).BeginInit();
            this.PartyTab.SuspendLayout();
            this.Dinner.SuspendLayout();
            this.Birthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberOfPeopleBD)).BeginInit();
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
            // CheckBoxFancyDecorations
            // 
            this.CheckBoxFancyDecorations.AutoSize = true;
            this.CheckBoxFancyDecorations.Checked = true;
            this.CheckBoxFancyDecorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxFancyDecorations.Location = new System.Drawing.Point(66, 82);
            this.CheckBoxFancyDecorations.Name = "CheckBoxFancyDecorations";
            this.CheckBoxFancyDecorations.Size = new System.Drawing.Size(115, 17);
            this.CheckBoxFancyDecorations.TabIndex = 2;
            this.CheckBoxFancyDecorations.Text = "Fancy Decorations";
            this.CheckBoxFancyDecorations.UseVisualStyleBackColor = true;
            this.CheckBoxFancyDecorations.CheckedChanged += new System.EventHandler(this.CheckBoxFancyDecorations_CheckedChanged);
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
            this.CheckBoxHealthyOption.CheckedChanged += new System.EventHandler(this.CheckBoxHealthyOption_CheckedChanged);
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
            this.Dinner.Controls.Add(this.CheckBoxFancyDecorations);
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
            this.Birthday.Controls.Add(this.TextBoxCakeWriting);
            this.Birthday.Controls.Add(this.LabelWritingTooLong);
            this.Birthday.Controls.Add(this.label4);
            this.Birthday.Controls.Add(this.label1);
            this.Birthday.Controls.Add(this.LabelCostDisplayBD);
            this.Birthday.Controls.Add(this.NumericUpDownNumberOfPeopleBD);
            this.Birthday.Controls.Add(this.label3);
            this.Birthday.Controls.Add(this.CheckBoxFancyDecorationsBD);
            this.Birthday.Location = new System.Drawing.Point(4, 22);
            this.Birthday.Name = "Birthday";
            this.Birthday.Padding = new System.Windows.Forms.Padding(3);
            this.Birthday.Size = new System.Drawing.Size(261, 243);
            this.Birthday.TabIndex = 1;
            this.Birthday.Text = "Birthday";
            this.Birthday.UseVisualStyleBackColor = true;
            // 
            // TextBoxCakeWriting
            // 
            this.TextBoxCakeWriting.Location = new System.Drawing.Point(24, 113);
            this.TextBoxCakeWriting.Name = "TextBoxCakeWriting";
            this.TextBoxCakeWriting.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCakeWriting.TabIndex = 14;
            this.TextBoxCakeWriting.Text = "Happy Birthday!";
            this.TextBoxCakeWriting.TextChanged += new System.EventHandler(this.TextBoxCakeWriting_TextChanged);
            // 
            // LabelWritingTooLong
            // 
            this.LabelWritingTooLong.AutoSize = true;
            this.LabelWritingTooLong.BackColor = System.Drawing.Color.DarkRed;
            this.LabelWritingTooLong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelWritingTooLong.Location = new System.Drawing.Point(100, 97);
            this.LabelWritingTooLong.Name = "LabelWritingTooLong";
            this.LabelWritingTooLong.Size = new System.Drawing.Size(63, 13);
            this.LabelWritingTooLong.TabIndex = 13;
            this.LabelWritingTooLong.Text = "TOO LONG";
            this.LabelWritingTooLong.Visible = false;
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
            // LabelCostDisplayBD
            // 
            this.LabelCostDisplayBD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LabelCostDisplayBD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCostDisplayBD.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LabelCostDisplayBD.Location = new System.Drawing.Point(24, 159);
            this.LabelCostDisplayBD.Name = "LabelCostDisplayBD";
            this.LabelCostDisplayBD.Size = new System.Drawing.Size(91, 25);
            this.LabelCostDisplayBD.TabIndex = 11;
            // 
            // NumericUpDownNumberOfPeopleBD
            // 
            this.NumericUpDownNumberOfPeopleBD.Location = new System.Drawing.Point(144, 37);
            this.NumericUpDownNumberOfPeopleBD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericUpDownNumberOfPeopleBD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownNumberOfPeopleBD.Name = "NumericUpDownNumberOfPeopleBD";
            this.NumericUpDownNumberOfPeopleBD.Size = new System.Drawing.Size(95, 20);
            this.NumericUpDownNumberOfPeopleBD.TabIndex = 7;
            this.NumericUpDownNumberOfPeopleBD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownNumberOfPeopleBD.ValueChanged += new System.EventHandler(this.NumericUpDownNumberOfPeopleBD_ValueChanged);
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
            // CheckBoxFancyDecorationsBD
            // 
            this.CheckBoxFancyDecorationsBD.AutoSize = true;
            this.CheckBoxFancyDecorationsBD.Checked = true;
            this.CheckBoxFancyDecorationsBD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxFancyDecorationsBD.Location = new System.Drawing.Point(24, 63);
            this.CheckBoxFancyDecorationsBD.Name = "CheckBoxFancyDecorationsBD";
            this.CheckBoxFancyDecorationsBD.Size = new System.Drawing.Size(115, 17);
            this.CheckBoxFancyDecorationsBD.TabIndex = 8;
            this.CheckBoxFancyDecorationsBD.Text = "Fancy Decorations";
            this.CheckBoxFancyDecorationsBD.UseVisualStyleBackColor = true;
            this.CheckBoxFancyDecorationsBD.CheckedChanged += new System.EventHandler(this.CheckBoxFancyDecorationsBD_CheckedChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberOfPeopleBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelNumberOfPeople;
        private System.Windows.Forms.NumericUpDown NumericUpDownNumberOfPeople;
        private System.Windows.Forms.CheckBox CheckBoxFancyDecorations;
        private System.Windows.Forms.CheckBox CheckBoxHealthyOption;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelCostDisplay;
        private System.Windows.Forms.TabControl PartyTab;
        private System.Windows.Forms.TabPage Dinner;
        private System.Windows.Forms.TabPage Birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCostDisplayBD;
        private System.Windows.Forms.NumericUpDown NumericUpDownNumberOfPeopleBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxFancyDecorationsBD;
        private System.Windows.Forms.TextBox TextBoxCakeWriting;
        private System.Windows.Forms.Label LabelWritingTooLong;
        private System.Windows.Forms.Label label4;
    }
}

