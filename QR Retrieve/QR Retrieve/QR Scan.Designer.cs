namespace QR_Retrieve
{
    partial class QR_Scan
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
            this.pictureBoxQRToConvert = new System.Windows.Forms.PictureBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSaveTextConverted = new System.Windows.Forms.Button();
            this.textBoxQRConvertedText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRToConvert)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxQRToConvert
            // 
            this.pictureBoxQRToConvert.Location = new System.Drawing.Point(12, 70);
            this.pictureBoxQRToConvert.Name = "pictureBoxQRToConvert";
            this.pictureBoxQRToConvert.Size = new System.Drawing.Size(365, 320);
            this.pictureBoxQRToConvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQRToConvert.TabIndex = 0;
            this.pictureBoxQRToConvert.TabStop = false;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(93, 406);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(211, 44);
            this.btnDecode.TabIndex = 1;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(12, 24);
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(365, 20);
            this.textBoxOpenFile.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(434, 24);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(148, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSaveTextConverted
            // 
            this.btnSaveTextConverted.Location = new System.Drawing.Point(493, 406);
            this.btnSaveTextConverted.Name = "btnSaveTextConverted";
            this.btnSaveTextConverted.Size = new System.Drawing.Size(211, 44);
            this.btnSaveTextConverted.TabIndex = 5;
            this.btnSaveTextConverted.Text = "Save";
            this.btnSaveTextConverted.UseVisualStyleBackColor = true;
            this.btnSaveTextConverted.Click += new System.EventHandler(this.btnSaveTextConverted_Click);
            // 
            // textBoxQRConvertedText
            // 
            this.textBoxQRConvertedText.Location = new System.Drawing.Point(417, 70);
            this.textBoxQRConvertedText.Name = "textBoxQRConvertedText";
            this.textBoxQRConvertedText.Size = new System.Drawing.Size(371, 320);
            this.textBoxQRConvertedText.TabIndex = 6;
            this.textBoxQRConvertedText.Text = "";
            // 
            // QR_Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.textBoxQRConvertedText);
            this.Controls.Add(this.btnSaveTextConverted);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBoxOpenFile);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.pictureBoxQRToConvert);
            this.Name = "QR_Scan";
            this.Text = "QR_Scan";
            this.Load += new System.EventHandler(this.QR_Scan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRToConvert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQRToConvert;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox textBoxOpenFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSaveTextConverted;
        private System.Windows.Forms.RichTextBox textBoxQRConvertedText;
    }
}