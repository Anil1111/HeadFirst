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
            this.PeopleQuantityNm.Name = "PeopleQuantityNm";
            this.PeopleQuantityNm.Size = new System.Drawing.Size(95, 20);
            this.PeopleQuantityNm.TabIndex = 1;
            // 
            // FantasyDecorationsCb
            // 
            this.FantasyDecorationsCb.AutoSize = true;
            this.FantasyDecorationsCb.Location = new System.Drawing.Point(39, 95);
            this.FantasyDecorationsCb.Name = "FantasyDecorationsCb";
            this.FantasyDecorationsCb.Size = new System.Drawing.Size(123, 17);
            this.FantasyDecorationsCb.TabIndex = 2;
            this.FantasyDecorationsCb.Text = "Fantasy Decorations";
            this.FantasyDecorationsCb.UseVisualStyleBackColor = true;
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
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Location = new System.Drawing.Point(36, 167);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(28, 13);
            this.CostLbl.TabIndex = 4;
            this.CostLbl.Text = "Cost";
            // 
            // PartyPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 274);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.HealthyOptionCb);
            this.Controls.Add(this.FantasyDecorationsCb);
            this.Controls.Add(this.PeopleQuantityNm);
            this.Controls.Add(this.PeopleQuantityLbl);
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
    }
}

