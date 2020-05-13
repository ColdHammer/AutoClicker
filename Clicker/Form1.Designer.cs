namespace AutoClicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.NumericUpDown();
            this.lbl_txtStart = new System.Windows.Forms.Label();
            this.lbl_txtStop = new System.Windows.Forms.Label();
            this.intClickSize = new System.Windows.Forms.NumericUpDown();
            this.lbl_TextHold = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHold = new AutoClicker.EditableLabel();
            this.lblStop = new AutoClicker.EditableLabel();
            this.lblStart = new AutoClicker.EditableLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intClickSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(0, 183);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(226, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            this.btnStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // txtInterval
            // 
            this.txtInterval.BackColor = System.Drawing.Color.Black;
            this.txtInterval.ForeColor = System.Drawing.Color.Lime;
            this.txtInterval.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtInterval.Location = new System.Drawing.Point(133, 129);
            this.txtInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(81, 20);
            this.txtInterval.TabIndex = 1;
            this.txtInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lbl_txtStart
            // 
            this.lbl_txtStart.AutoSize = true;
            this.lbl_txtStart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_txtStart.Location = new System.Drawing.Point(28, 29);
            this.lbl_txtStart.Name = "lbl_txtStart";
            this.lbl_txtStart.Size = new System.Drawing.Size(53, 13);
            this.lbl_txtStart.TabIndex = 4;
            this.lbl_txtStart.Text = "Key Start:";
            // 
            // lbl_txtStop
            // 
            this.lbl_txtStop.AutoSize = true;
            this.lbl_txtStop.BackColor = System.Drawing.Color.Transparent;
            this.lbl_txtStop.Location = new System.Drawing.Point(28, 53);
            this.lbl_txtStop.Name = "lbl_txtStop";
            this.lbl_txtStop.Size = new System.Drawing.Size(53, 13);
            this.lbl_txtStop.TabIndex = 5;
            this.lbl_txtStop.Text = "Key Stop:";
            // 
            // intClickSize
            // 
            this.intClickSize.BackColor = System.Drawing.Color.Black;
            this.intClickSize.ForeColor = System.Drawing.Color.Lime;
            this.intClickSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.intClickSize.Location = new System.Drawing.Point(133, 103);
            this.intClickSize.Name = "intClickSize";
            this.intClickSize.Size = new System.Drawing.Size(81, 20);
            this.intClickSize.TabIndex = 8;
            this.intClickSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intClickSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lbl_TextHold
            // 
            this.lbl_TextHold.AutoSize = true;
            this.lbl_TextHold.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TextHold.Location = new System.Drawing.Point(28, 76);
            this.lbl_TextHold.Name = "lbl_TextHold";
            this.lbl_TextHold.Size = new System.Drawing.Size(53, 13);
            this.lbl_TextHold.TabIndex = 9;
            this.lbl_TextHold.Text = "Key Hold:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Interval Down:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Interval Up:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(209, -5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label3_MouseUp);
            // 
            // lblHold
            // 
            this.lblHold.AutoSize = true;
            this.lblHold.BackColor = System.Drawing.Color.DarkRed;
            this.lblHold.ForeColor = System.Drawing.Color.Coral;
            this.lblHold.KeyValue = 0;
            this.lblHold.Location = new System.Drawing.Point(130, 76);
            this.lblHold.Name = "lblHold";
            this.lblHold.Size = new System.Drawing.Size(33, 13);
            this.lblHold.TabIndex = 10;
            this.lblHold.Text = "None";
            this.lblHold.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.BackColor = System.Drawing.Color.DarkRed;
            this.lblStop.ForeColor = System.Drawing.Color.Coral;
            this.lblStop.KeyValue = 0;
            this.lblStop.Location = new System.Drawing.Point(130, 53);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(33, 13);
            this.lblStop.TabIndex = 7;
            this.lblStop.Text = "None";
            this.lblStop.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.DarkRed;
            this.lblStart.ForeColor = System.Drawing.Color.Coral;
            this.lblStart.KeyValue = 0;
            this.lblStart.Location = new System.Drawing.Point(130, 29);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(33, 13);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "None";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(226, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHold);
            this.Controls.Add(this.lbl_TextHold);
            this.Controls.Add(this.intClickSize);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lbl_txtStop);
            this.Controls.Add(this.lbl_txtStart);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intClickSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown txtInterval;
        private System.Windows.Forms.Label lbl_txtStart;
        private System.Windows.Forms.Label lbl_txtStop;
        private EditableLabel lblStart;
        private EditableLabel lblStop;
        private System.Windows.Forms.NumericUpDown intClickSize;
        private EditableLabel lblHold;
        private System.Windows.Forms.Label lbl_TextHold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

