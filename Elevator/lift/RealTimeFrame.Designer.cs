namespace lift
{
    partial class RealTimeFrame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInfPassenger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNPasseger = new System.Windows.Forms.Label();
            this.labelStatusLift = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxInfPassenger);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(20, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(352, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passenger info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxInfPassenger
            // 
            this.textBoxInfPassenger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfPassenger.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfPassenger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfPassenger.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxInfPassenger.Location = new System.Drawing.Point(4, 19);
            this.textBoxInfPassenger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInfPassenger.MaximumSize = new System.Drawing.Size(750, 812);
            this.textBoxInfPassenger.Multiline = true;
            this.textBoxInfPassenger.Name = "textBoxInfPassenger";
            this.textBoxInfPassenger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfPassenger.Size = new System.Drawing.Size(341, 370);
            this.textBoxInfPassenger.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of passengers:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelNPasseger
            // 
            this.labelNPasseger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNPasseger.AutoSize = true;
            this.labelNPasseger.Location = new System.Drawing.Point(169, 421);
            this.labelNPasseger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNPasseger.Name = "labelNPasseger";
            this.labelNPasseger.Size = new System.Drawing.Size(13, 13);
            this.labelNPasseger.TabIndex = 6;
            this.labelNPasseger.Text = "0";
            this.labelNPasseger.Click += new System.EventHandler(this.labelNPasseger_Click);
            // 
            // labelStatusLift
            // 
            this.labelStatusLift.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelStatusLift.AutoSize = true;
            this.labelStatusLift.Location = new System.Drawing.Point(205, 421);
            this.labelStatusLift.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatusLift.Name = "labelStatusLift";
            this.labelStatusLift.Size = new System.Drawing.Size(75, 13);
            this.labelStatusLift.TabIndex = 7;
            this.labelStatusLift.Text = "Elevator state:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(370, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(326, 393);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passenger status";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxStatus.Location = new System.Drawing.Point(6, 19);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatus.Size = new System.Drawing.Size(315, 370);
            this.textBoxStatus.TabIndex = 1;
            // 
            // RealTimeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelStatusLift);
            this.Controls.Add(this.labelNPasseger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RealTimeFrame";
            this.Text = "Current information";
            this.Load += new System.EventHandler(this.Start_lift_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNPasseger;
        private System.Windows.Forms.Label labelStatusLift;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxInfPassenger;
        private System.Windows.Forms.TextBox textBoxStatus;
    }
}