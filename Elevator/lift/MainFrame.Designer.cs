namespace lift
{
    partial class MainFrame
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bStop = new System.Windows.Forms.Button();
            this.bView = new System.Windows.Forms.Button();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelLift = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxInFloor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxFFlor = new System.Windows.Forms.TextBox();
            this.tBoxWeight = new System.Windows.Forms.TextBox();
            this.tBoxNumberFloor = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.LabelNumPass = new System.Windows.Forms.LinkLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBoxCapacity = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(547, 283);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(520, 167);
            this.bStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(92, 37);
            this.bStop.TabIndex = 3;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bView
            // 
            this.bView.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bView.Location = new System.Drawing.Point(520, 209);
            this.bView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bView.Name = "bView";
            this.bView.Size = new System.Drawing.Size(92, 39);
            this.bView.TabIndex = 4;
            this.bView.Text = "Result";
            this.bView.UseVisualStyleBackColor = true;
            this.bView.Click += new System.EventHandler(this.bWiew_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(36, 25);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(98, 20);
            this.labelPass.TabIndex = 5;
            this.labelPass.Text = "Passanger";
            // 
            // labelLift
            // 
            this.labelLift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLift.AutoSize = true;
            this.labelLift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLift.Location = new System.Drawing.Point(233, 25);
            this.labelLift.Name = "labelLift";
            this.labelLift.Size = new System.Drawing.Size(78, 20);
            this.labelLift.TabIndex = 6;
            this.labelLift.Text = "Elevator";
            this.labelLift.Click += new System.EventHandler(this.labelLift_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Initial floor:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Target floor:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(36, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Weight:";
            // 
            // tBoxInFloor
            // 
            this.tBoxInFloor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBoxInFloor.Location = new System.Drawing.Point(176, 167);
            this.tBoxInFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxInFloor.Name = "tBoxInFloor";
            this.tBoxInFloor.Size = new System.Drawing.Size(41, 22);
            this.tBoxInFloor.TabIndex = 10;
            this.tBoxInFloor.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of floors:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Load capacity";
            // 
            // tBoxFFlor
            // 
            this.tBoxFFlor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBoxFFlor.Location = new System.Drawing.Point(176, 201);
            this.tBoxFFlor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxFFlor.Name = "tBoxFFlor";
            this.tBoxFFlor.Size = new System.Drawing.Size(41, 22);
            this.tBoxFFlor.TabIndex = 13;
            this.tBoxFFlor.Text = "0";
            // 
            // tBoxWeight
            // 
            this.tBoxWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBoxWeight.Location = new System.Drawing.Point(176, 234);
            this.tBoxWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxWeight.Name = "tBoxWeight";
            this.tBoxWeight.Size = new System.Drawing.Size(41, 22);
            this.tBoxWeight.TabIndex = 14;
            this.tBoxWeight.Text = "0";
            // 
            // tBoxNumberFloor
            // 
            this.tBoxNumberFloor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tBoxNumberFloor.Location = new System.Drawing.Point(401, 167);
            this.tBoxNumberFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNumberFloor.Name = "tBoxNumberFloor";
            this.tBoxNumberFloor.Size = new System.Drawing.Size(39, 22);
            this.tBoxNumberFloor.TabIndex = 16;
            this.tBoxNumberFloor.Text = "0";
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAdd.Enabled = false;
            this.bAdd.Location = new System.Drawing.Point(40, 276);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(97, 27);
            this.bAdd.TabIndex = 17;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bOk
            // 
            this.bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOk.Location = new System.Drawing.Point(239, 278);
            this.bOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(45, 25);
            this.bOk.TabIndex = 18;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // LabelNumPass
            // 
            this.LabelNumPass.AutoSize = true;
            this.LabelNumPass.LinkColor = System.Drawing.Color.Black;
            this.LabelNumPass.Location = new System.Drawing.Point(173, 27);
            this.LabelNumPass.Name = "LabelNumPass";
            this.LabelNumPass.Size = new System.Drawing.Size(16, 17);
            this.LabelNumPass.TabIndex = 19;
            this.LabelNumPass.TabStop = true;
            this.LabelNumPass.Text = "1";
            // 
            // tBoxCapacity
            // 
            this.tBoxCapacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tBoxCapacity.Location = new System.Drawing.Point(401, 219);
            this.tBoxCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxCapacity.Name = "tBoxCapacity";
            this.tBoxCapacity.Size = new System.Drawing.Size(39, 22);
            this.tBoxCapacity.TabIndex = 25;
            this.tBoxCapacity.Text = "0";
            // 
            // bStart
            // 
            this.bStart.Enabled = false;
            this.bStart.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(520, 254);
            this.bStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(92, 38);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(731, 353);
            this.Controls.Add(this.bView);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tBoxCapacity);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.labelLift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.LabelNumPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxInFloor);
            this.Controls.Add(this.tBoxNumberFloor);
            this.Controls.Add(this.tBoxWeight);
            this.Controls.Add(this.tBoxFFlor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.Text = "Elevator system";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bView;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelLift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxInFloor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxFFlor;
        private System.Windows.Forms.TextBox tBoxWeight;
        private System.Windows.Forms.TextBox tBoxNumberFloor;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.LinkLabel LabelNumPass;
        private System.Windows.Forms.TextBox tBoxCapacity;
        private System.Windows.Forms.Button bStart;
    }
}

