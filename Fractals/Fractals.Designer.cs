namespace Fractals
{
    partial class Fractals
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.countOfSteps = new System.Windows.Forms.NumericUpDown();
            this.LeftAngle = new System.Windows.Forms.TrackBar();
            this.zoom = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.RightAngle = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.startColor = new System.Windows.Forms.Button();
            this.endColor = new System.Windows.Forms.Button();
            this.fractal = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currentFractal = new System.Windows.Forms.Label();
            this.backgroundcolor = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.fractalname = new System.Windows.Forms.Label();
            this.format = new System.Windows.Forms.ComboBox();
            this.saveformat = new System.Windows.Forms.Label();
            this.stepscount = new System.Windows.Forms.Label();
            this.PenWidth = new System.Windows.Forms.TrackBar();
            this.widthLabel = new System.Windows.Forms.Label();
            this.spaceLable = new System.Windows.Forms.Label();
            this.CurrentFractalLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colors = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidth)).BeginInit();
            this.colors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(393, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 795);
            this.panel1.TabIndex = 0;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(0, 754);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1387, 41);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(1344, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(43, 777);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(6, 22);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(95, 23);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Start drawing";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // countOfSteps
            // 
            this.countOfSteps.Location = new System.Drawing.Point(107, 22);
            this.countOfSteps.Name = "countOfSteps";
            this.countOfSteps.Size = new System.Drawing.Size(33, 23);
            this.countOfSteps.TabIndex = 2;
            this.countOfSteps.ValueChanged += new System.EventHandler(this.CountOfSteps_Change);
            // 
            // LeftAngle
            // 
            this.LeftAngle.Location = new System.Drawing.Point(122, 379);
            this.LeftAngle.Maximum = 25;
            this.LeftAngle.Minimum = -25;
            this.LeftAngle.Name = "LeftAngle";
            this.LeftAngle.Size = new System.Drawing.Size(104, 45);
            this.LeftAngle.TabIndex = 5;
            this.LeftAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LeftAngle.Scroll += new System.EventHandler(this.LeftAngle_Scroll);
            // 
            // zoom
            // 
            this.zoom.Location = new System.Drawing.Point(12, 379);
            this.zoom.Maximum = 1000;
            this.zoom.Minimum = 100;
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(104, 45);
            this.zoom.TabIndex = 6;
            this.zoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoom.Value = 150;
            this.zoom.Scroll += new System.EventHandler(this.zoom_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Left side angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zoom";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(12, 443);
            this.length.Maximum = 150;
            this.length.Minimum = 15;
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(104, 45);
            this.length.TabIndex = 10;
            this.length.TickStyle = System.Windows.Forms.TickStyle.None;
            this.length.Value = 150;
            this.length.Scroll += new System.EventHandler(this.length_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Length of each step";
            // 
            // RightAngle
            // 
            this.RightAngle.Location = new System.Drawing.Point(122, 443);
            this.RightAngle.Maximum = 25;
            this.RightAngle.Minimum = -25;
            this.RightAngle.Name = "RightAngle";
            this.RightAngle.Size = new System.Drawing.Size(104, 45);
            this.RightAngle.TabIndex = 12;
            this.RightAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RightAngle.Scroll += new System.EventHandler(this.RightAngle_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Right side angle";
            // 
            // startColor
            // 
            this.startColor.Location = new System.Drawing.Point(17, 51);
            this.startColor.Name = "startColor";
            this.startColor.Size = new System.Drawing.Size(75, 23);
            this.startColor.TabIndex = 15;
            this.startColor.Text = "Start color";
            this.startColor.UseVisualStyleBackColor = true;
            this.startColor.Click += new System.EventHandler(this.startColor_Click);
            // 
            // endColor
            // 
            this.endColor.Location = new System.Drawing.Point(98, 51);
            this.endColor.Name = "endColor";
            this.endColor.Size = new System.Drawing.Size(75, 23);
            this.endColor.TabIndex = 16;
            this.endColor.Text = "End color";
            this.endColor.UseVisualStyleBackColor = true;
            this.endColor.Click += new System.EventHandler(this.endcolor_Click);
            // 
            // fractal
            // 
            this.fractal.FormattingEnabled = true;
            this.fractal.ItemHeight = 15;
            this.fractal.Items.AddRange(new object[] {
            "Tree",
            "Koch",
            "Carpet",
            "Triangle",
            "Kantor"});
            this.fractal.Location = new System.Drawing.Point(12, 12);
            this.fractal.Name = "fractal";
            this.fractal.Size = new System.Drawing.Size(120, 94);
            this.fractal.TabIndex = 17;
            this.fractal.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-56, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            // 
            // currentFractal
            // 
            this.currentFractal.AutoSize = true;
            this.currentFractal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentFractal.Location = new System.Drawing.Point(138, 42);
            this.currentFractal.Name = "currentFractal";
            this.currentFractal.Size = new System.Drawing.Size(39, 21);
            this.currentFractal.TabIndex = 19;
            this.currentFractal.Text = "Tree";
            // 
            // backgroundcolor
            // 
            this.backgroundcolor.Location = new System.Drawing.Point(17, 22);
            this.backgroundcolor.Name = "backgroundcolor";
            this.backgroundcolor.Size = new System.Drawing.Size(156, 23);
            this.backgroundcolor.TabIndex = 20;
            this.backgroundcolor.Text = "Background color";
            this.backgroundcolor.UseVisualStyleBackColor = true;
            this.backgroundcolor.Click += new System.EventHandler(this.backgroundcolor_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(257, 36);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(114, 23);
            this.save.TabIndex = 21;
            this.save.Text = "Save fractal image";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(6, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(186, 23);
            this.name.TabIndex = 22;
            // 
            // fractalname
            // 
            this.fractalname.AutoSize = true;
            this.fractalname.Location = new System.Drawing.Point(6, 19);
            this.fractalname.Name = "fractalname";
            this.fractalname.Size = new System.Drawing.Size(102, 15);
            this.fractalname.TabIndex = 23;
            this.fractalname.Text = "Name your fractal";
            // 
            // format
            // 
            this.format.FormattingEnabled = true;
            this.format.Items.AddRange(new object[] {
            ".png",
            ".jpeg",
            ".gif",
            ".tiff",
            ".bmp"});
            this.format.Location = new System.Drawing.Point(198, 37);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(53, 23);
            this.format.TabIndex = 24;
            // 
            // saveformat
            // 
            this.saveformat.AutoSize = true;
            this.saveformat.Location = new System.Drawing.Point(198, 19);
            this.saveformat.Name = "saveformat";
            this.saveformat.Size = new System.Drawing.Size(45, 15);
            this.saveformat.TabIndex = 25;
            this.saveformat.Text = "Format";
            // 
            // stepscount
            // 
            this.stepscount.AutoSize = true;
            this.stepscount.Location = new System.Drawing.Point(146, 30);
            this.stepscount.Name = "stepscount";
            this.stepscount.Size = new System.Drawing.Size(95, 15);
            this.stepscount.TabIndex = 26;
            this.stepscount.Text = "Amount of steps";
            // 
            // PenWidth
            // 
            this.PenWidth.Location = new System.Drawing.Point(250, 379);
            this.PenWidth.Minimum = 1;
            this.PenWidth.Name = "PenWidth";
            this.PenWidth.Size = new System.Drawing.Size(104, 45);
            this.PenWidth.TabIndex = 27;
            this.PenWidth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PenWidth.Value = 1;
            this.PenWidth.Scroll += new System.EventHandler(this.PenWidth_Sroll);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(263, 361);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(76, 15);
            this.widthLabel.TabIndex = 28;
            this.widthLabel.Text = "Width of pen";
            // 
            // spaceLable
            // 
            this.spaceLable.AutoSize = true;
            this.spaceLable.Location = new System.Drawing.Point(122, 361);
            this.spaceLable.Name = "spaceLable";
            this.spaceLable.Size = new System.Drawing.Size(113, 15);
            this.spaceLable.TabIndex = 29;
            this.spaceLable.Text = "Space between lines";
            // 
            // CurrentFractalLabel
            // 
            this.CurrentFractalLabel.AutoSize = true;
            this.CurrentFractalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentFractalLabel.Location = new System.Drawing.Point(138, 21);
            this.CurrentFractalLabel.Name = "CurrentFractalLabel";
            this.CurrentFractalLabel.Size = new System.Drawing.Size(182, 21);
            this.CurrentFractalLabel.TabIndex = 30;
            this.CurrentFractalLabel.Text = "Currently chosen fractal :";
            // 
            // colors
            // 
            this.colors.Controls.Add(this.backgroundcolor);
            this.colors.Controls.Add(this.startColor);
            this.colors.Controls.Add(this.endColor);
            this.colors.Location = new System.Drawing.Point(12, 112);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(192, 84);
            this.colors.TabIndex = 31;
            this.colors.TabStop = false;
            this.colors.Text = "Colors";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drawButton);
            this.groupBox1.Controls.Add(this.countOfSteps);
            this.groupBox1.Controls.Add(this.stepscount);
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 53);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fractalname);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.format);
            this.groupBox2.Controls.Add(this.saveformat);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 73);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saving";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fractals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 796);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.colors);
            this.Controls.Add(this.CurrentFractalLabel);
            this.Controls.Add(this.spaceLable);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.PenWidth);
            this.Controls.Add(this.currentFractal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fractal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RightAngle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoom);
            this.Controls.Add(this.LeftAngle);
            this.Controls.Add(this.panel1);
            this.Name = "Fractals";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmMain_ResizeEnd);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidth)).EndInit();
            this.colors.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.NumericUpDown countOfSteps;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox fractal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentFractal;
        private System.Windows.Forms.Button backgroundcolor;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label fractalname;
        private System.Windows.Forms.ComboBox format;
        private System.Windows.Forms.Label saveformat;
        private System.Windows.Forms.Label stepscount;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TrackBar PenWidth;
        private System.Windows.Forms.Label spaceLable;
        public System.Windows.Forms.TrackBar LeftAngle;
        public System.Windows.Forms.TrackBar zoom;
        public System.Windows.Forms.TrackBar length;
        public System.Windows.Forms.TrackBar RightAngle;
        public System.Windows.Forms.HScrollBar hScrollBar1;
        public System.Windows.Forms.VScrollBar vScrollBar1;
        public System.Windows.Forms.Button startColor;
        public System.Windows.Forms.Button endColor;
        private System.Windows.Forms.Label CurrentFractalLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox colors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

