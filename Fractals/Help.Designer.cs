namespace Fractals
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.close = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.testStartDrawButton = new System.Windows.Forms.Button();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.pleaseReadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(713, 415);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(186, 109);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "In order to select a fractal choose one of the items in the list such as this one" +
    "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Tree",
            "Koch",
            "Carpet",
            "Triangle",
            "Kantor"});
            this.listBox1.Location = new System.Drawing.Point(204, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 109);
            this.listBox1.TabIndex = 17;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(12, 128);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(186, 80);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "Move trackbars like this one to change different values of the fractal";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(204, 127);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(120, 45);
            this.trackBar1.TabIndex = 19;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox3.Location = new System.Drawing.Point(12, 215);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(186, 167);
            this.richTextBox3.TabIndex = 20;
            this.richTextBox3.Text = "Use scrollbars like these ones to move the image. Note that sometimes it can be n" +
    "ot centered and it might seem as if nothing was drawn";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(204, 365);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(120, 17);
            this.hScrollBar1.TabIndex = 21;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(307, 215);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 150);
            this.vScrollBar1.TabIndex = 22;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox4.Location = new System.Drawing.Point(330, 12);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(186, 167);
            this.richTextBox4.TabIndex = 20;
            this.richTextBox4.Text = "Your fractal will not be rendering unless the \"Start drawing\" button is enabled. " +
    "Once you press it the fractals will start rendering. If you press it again the p" +
    "rocess will stop";
            // 
            // testStartDrawButton
            // 
            this.testStartDrawButton.Location = new System.Drawing.Point(523, 13);
            this.testStartDrawButton.Name = "testStartDrawButton";
            this.testStartDrawButton.Size = new System.Drawing.Size(93, 23);
            this.testStartDrawButton.TabIndex = 23;
            this.testStartDrawButton.Text = "Start drawing";
            this.testStartDrawButton.UseVisualStyleBackColor = true;
            this.testStartDrawButton.Click += new System.EventHandler(this.testStartDrawButton_Click);
            // 
            // richTextBox5
            // 
            this.richTextBox5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox5.Location = new System.Drawing.Point(330, 198);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(186, 167);
            this.richTextBox5.TabIndex = 20;
            this.richTextBox5.Text = "To change the amount of steps rendered in the fractal you can press the arrows or" +
    " type a number by hand in an element like this one";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(522, 198);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(30, 23);
            this.numericUpDown1.TabIndex = 25;
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(558, 197);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(239, 146);
            this.richTextBox6.TabIndex = 26;
            this.richTextBox6.Text = resources.GetString("richTextBox6.Text");
            // 
            // pleaseReadLabel
            // 
            this.pleaseReadLabel.AutoSize = true;
            this.pleaseReadLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pleaseReadLabel.Location = new System.Drawing.Point(617, 169);
            this.pleaseReadLabel.Name = "pleaseReadLabel";
            this.pleaseReadLabel.Size = new System.Drawing.Size(109, 25);
            this.pleaseReadLabel.TabIndex = 27;
            this.pleaseReadLabel.Text = "Please read";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pleaseReadLabel);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.testStartDrawButton);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.close);
            this.Name = "Help";
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button testStartDrawButton;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Label pleaseReadLabel;
    }
}