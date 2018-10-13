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
            ((System.ComponentModel.ISupportInitialize)(this.PeopleQuantityNm)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleQuantityLbl
            // 
            this.PeopleQuantityLbl.AutoSize = true;
            this.PeopleQuantityLbl.Location = new System.Drawing.Point(36, 38);
            this.PeopleQuantityLbl.Name = "PeopleQuantityLbl";
            this.PeopleQuantityLbl.Size = new System.Drawing.Size(98, 13);
            this.PeopleQuantityLbl.TabIndex = 0;
            this.PeopleQuantityLbl.Text = "How many people?";
            // 
            // PeopleQuantityNm
            // 
            this.PeopleQuantityNm.Location = new System.Drawing.Point(39, 55);
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
            this.FantasyDecorationsCb.Location = new System.Drawing.Point(39, 95);
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
            this.HealthyOptionCb.Location = new System.Drawing.Point(39, 130);
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
            this.CostLbl.Location = new System.Drawing.Point(36, 166);
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
            this.CostDisplay.Location = new System.Drawing.Point(80, 160);
            this.CostDisplay.Name = "CostDisplay";
            this.CostDisplay.Size = new System.Drawing.Size(91, 25);
            this.CostDisplay.TabIndex = 5;
            // 
            // PartyPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 217);
            this.Controls.Add(this.CostDisplay);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.HealthyOptionCb);
            this.Controls.Add(this.FantasyDecorationsCb);
            this.Controls.Add(this.PeopleQuantityNm);
            this.Controls.Add(this.PeopleQuantityLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartyPlannerForm";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleQuantityNm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PeopleQuantityLbl;
        private System.Windows.Forms.NumericUpDown PeopleQuantityNm;
        private System.Windows.Forms.CheckBox FantasyDecorationsCb;
        private System.Windows.Forms.CheckBox HealthyOptionCb;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label CostDisplay;
    }
}

