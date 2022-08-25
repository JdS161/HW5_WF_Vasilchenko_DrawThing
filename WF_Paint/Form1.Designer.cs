namespace HW5_WF_Vasilchenko_DrawThing
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
            this.paintPanel = new System.Windows.Forms.Panel();
            this.toolBox = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radNumber = new System.Windows.Forms.NumericUpDown();
            this.lenNumber = new System.Windows.Forms.NumericUpDown();
            this.widNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.control1 = new System.Windows.Forms.Control();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // paintPanel
            // 
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paintPanel.Location = new System.Drawing.Point(12, 12);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(1295, 497);
            this.paintPanel.TabIndex = 0;
            this.paintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseDown);
            this.paintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseMove);
            this.paintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintPanel_MouseUp);
            // 
            // toolBox
            // 
            this.toolBox.Controls.Add(this.checkBox3);
            this.toolBox.Controls.Add(this.checkBox2);
            this.toolBox.Controls.Add(this.radNumber);
            this.toolBox.Controls.Add(this.lenNumber);
            this.toolBox.Controls.Add(this.widNumber);
            this.toolBox.Controls.Add(this.label3);
            this.toolBox.Controls.Add(this.label2);
            this.toolBox.Controls.Add(this.label1);
            this.toolBox.Controls.Add(this.checkBox1);
            this.toolBox.Controls.Add(this.button1);
            this.toolBox.Controls.Add(this.trackBar1);
            this.toolBox.Controls.Add(this.cPanel);
            this.toolBox.Location = new System.Drawing.Point(320, 515);
            this.toolBox.Name = "toolBox";
            this.toolBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolBox.Size = new System.Drawing.Size(745, 162);
            this.toolBox.TabIndex = 1;
            this.toolBox.TabStop = false;
            this.toolBox.Text = "Panel";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Image = ((System.Drawing.Image)(resources.GetObject("checkBox3.Image")));
            this.checkBox3.Location = new System.Drawing.Point(293, 25);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 56);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
            this.checkBox2.Location = new System.Drawing.Point(427, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 56);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // radNumber
            // 
            this.radNumber.Location = new System.Drawing.Point(619, 112);
            this.radNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.radNumber.Name = "radNumber";
            this.radNumber.Size = new System.Drawing.Size(120, 26);
            this.radNumber.TabIndex = 12;
            this.radNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lenNumber
            // 
            this.lenNumber.Location = new System.Drawing.Point(619, 55);
            this.lenNumber.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.lenNumber.Name = "lenNumber";
            this.lenNumber.Size = new System.Drawing.Size(120, 26);
            this.lenNumber.TabIndex = 11;
            this.lenNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // widNumber
            // 
            this.widNumber.Location = new System.Drawing.Point(619, 16);
            this.widNumber.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.widNumber.Name = "widNumber";
            this.widNumber.Size = new System.Drawing.Size(120, 26);
            this.widNumber.TabIndex = 10;
            this.widNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(513, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Radius";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(513, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Length";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(513, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.Location = new System.Drawing.Point(427, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 56);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(217, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 56);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(82, 25);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(129, 69);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 5;
            // 
            // cPanel
            // 
            this.cPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cPanel.Location = new System.Drawing.Point(6, 25);
            this.cPanel.Name = "cPanel";
            this.cPanel.Size = new System.Drawing.Size(70, 69);
            this.cPanel.TabIndex = 0;
            this.cPanel.DoubleClick += new System.EventHandler(this.cPanel_DoubleClick);
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(0, 0);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(0, 0);
            this.control1.TabIndex = 0;
            this.control1.Text = "control1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 689);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.paintPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DrawThing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolBox.ResumeLayout(false);
            this.toolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.CheckBox checkBox3;

        private System.Windows.Forms.CheckBox checkBox2;

        private System.Windows.Forms.NumericUpDown widNumber;
        private System.Windows.Forms.NumericUpDown lenNumber;
        private System.Windows.Forms.NumericUpDown radNumber;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.Control control1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.Panel cPanel;

        private System.Windows.Forms.GroupBox toolBox;

        private System.Windows.Forms.Panel paintPanel;

        #endregion
    }
}