namespace Fractals
{
    partial class ErrorPopUp
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorType = new System.Windows.Forms.Label();
            this.ErrorHeadline = new System.Windows.Forms.Label();
            this.CloseButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ErrorType
            // 
            this.ErrorType.AutoSize = true;
            this.ErrorType.Location = new System.Drawing.Point(12, 58);
            this.ErrorType.Name = "ErrorType";
            this.ErrorType.Size = new System.Drawing.Size(38, 15);
            this.ErrorType.TabIndex = 0;
            this.ErrorType.Text = "label1";
            // 
            // ErrorHeadline
            // 
            this.ErrorHeadline.AutoSize = true;
            this.ErrorHeadline.Location = new System.Drawing.Point(12, 33);
            this.ErrorHeadline.Name = "ErrorHeadline";
            this.ErrorHeadline.Size = new System.Drawing.Size(32, 15);
            this.ErrorHeadline.TabIndex = 1;
            this.ErrorHeadline.Text = "Error";
            // 
            // CloseButon
            // 
            this.CloseButon.Location = new System.Drawing.Point(227, 120);
            this.CloseButon.Name = "CloseButon";
            this.CloseButon.Size = new System.Drawing.Size(75, 23);
            this.CloseButon.TabIndex = 2;
            this.CloseButon.Text = "Close";
            this.CloseButon.UseVisualStyleBackColor = true;
            this.CloseButon.Click += new System.EventHandler(this.Close_Click);
            // 
            // ErrorPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 155);
            this.Controls.Add(this.CloseButon);
            this.Controls.Add(this.ErrorHeadline);
            this.Controls.Add(this.ErrorType);
            this.Name = "ErrorPopUp";
            this.Text = "Error";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ErrorType;
        private System.Windows.Forms.Button CloseButon;
        private System.Windows.Forms.Label ErrorHeadline;
    }
}