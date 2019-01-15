namespace lift
{
    partial class FinalFrame
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
            this.labelNumberTrip = new System.Windows.Forms.Label();
            this.labelFreeTrip = new System.Windows.Forms.Label();
            this.labelSumWeight = new System.Windows.Forms.Label();
            this.LabelNumberPassenger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumberTrip
            // 
            this.labelNumberTrip.AutoSize = true;
            this.labelNumberTrip.Location = new System.Drawing.Point(25, 62);
            this.labelNumberTrip.Name = "labelNumberTrip";
            this.labelNumberTrip.Size = new System.Drawing.Size(143, 17);
            this.labelNumberTrip.TabIndex = 1;
            this.labelNumberTrip.Text = "Total number of trips:";
            // 
            // labelFreeTrip
            // 
            this.labelFreeTrip.AutoSize = true;
            this.labelFreeTrip.Location = new System.Drawing.Point(25, 134);
            this.labelFreeTrip.Name = "labelFreeTrip";
            this.labelFreeTrip.Size = new System.Drawing.Size(145, 17);
            this.labelFreeTrip.TabIndex = 2;
            this.labelFreeTrip.Text = "Number of “idle” trips:";
            // 
            // labelSumWeight
            // 
            this.labelSumWeight.AutoSize = true;
            this.labelSumWeight.Location = new System.Drawing.Point(25, 199);
            this.labelSumWeight.Name = "labelSumWeight";
            this.labelSumWeight.Size = new System.Drawing.Size(88, 17);
            this.labelSumWeight.TabIndex = 3;
            this.labelSumWeight.Text = "Total weight:";
            // 
            // LabelNumberPassenger
            // 
            this.LabelNumberPassenger.AutoSize = true;
            this.LabelNumberPassenger.Location = new System.Drawing.Point(25, 265);
            this.LabelNumberPassenger.Name = "LabelNumberPassenger";
            this.LabelNumberPassenger.Size = new System.Drawing.Size(156, 17);
            this.LabelNumberPassenger.TabIndex = 4;
            this.LabelNumberPassenger.Text = "Number of passengers:";
            // 
            // FinalFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(337, 370);
            this.Controls.Add(this.LabelNumberPassenger);
            this.Controls.Add(this.labelSumWeight);
            this.Controls.Add(this.labelFreeTrip);
            this.Controls.Add(this.labelNumberTrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FinalFrame";
            this.Text = "Total information";
            this.Load += new System.EventHandler(this.FinalFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNumberTrip;
        private System.Windows.Forms.Label labelFreeTrip;
        private System.Windows.Forms.Label labelSumWeight;
        private System.Windows.Forms.Label LabelNumberPassenger;
    }
}