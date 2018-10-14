namespace Farm
{
    partial class CowCalculatorForm
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
            this.CowQuantityLabel = new System.Windows.Forms.Label();
            this.CowQuantityNm = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CowQuantityNm)).BeginInit();
            this.SuspendLayout();
            // 
            // CowQuantityLabel
            // 
            this.CowQuantityLabel.AutoSize = true;
            this.CowQuantityLabel.Location = new System.Drawing.Point(37, 65);
            this.CowQuantityLabel.Name = "CowQuantityLabel";
            this.CowQuantityLabel.Size = new System.Drawing.Size(70, 13);
            this.CowQuantityLabel.TabIndex = 0;
            this.CowQuantityLabel.Text = "Cow Quantity";
            // 
            // CowQuantityNm
            // 
            this.CowQuantityNm.Location = new System.Drawing.Point(113, 63);
            this.CowQuantityNm.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CowQuantityNm.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CowQuantityNm.Name = "CowQuantityNm";
            this.CowQuantityNm.Size = new System.Drawing.Size(120, 20);
            this.CowQuantityNm.TabIndex = 1;
            this.CowQuantityNm.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.CowQuantityNm.ValueChanged += new System.EventHandler(this.CowQuantityNm_ValueChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(93, 108);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(85, 24);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CowCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 212);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.CowQuantityNm);
            this.Controls.Add(this.CowQuantityLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CowCalculatorForm";
            this.Text = "Cow Calculator";
            this.Load += new System.EventHandler(this.CowCalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CowQuantityNm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CowQuantityLabel;
        private System.Windows.Forms.NumericUpDown CowQuantityNm;
        private System.Windows.Forms.Button CalculateButton;
    }
}

