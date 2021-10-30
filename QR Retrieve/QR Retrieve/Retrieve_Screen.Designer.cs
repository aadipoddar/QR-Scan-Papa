namespace QR_Retrieve
{
    partial class Retrieve_Screen
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
            this.textBoxShowData = new System.Windows.Forms.RichTextBox();
            this.btnLiveData = new System.Windows.Forms.Button();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnGenQR = new System.Windows.Forms.Button();
            this.btnQRDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShowData
            // 
            this.textBoxShowData.Location = new System.Drawing.Point(12, 102);
            this.textBoxShowData.Name = "textBoxShowData";
            this.textBoxShowData.Size = new System.Drawing.Size(761, 406);
            this.textBoxShowData.TabIndex = 0;
            this.textBoxShowData.Text = "";
            // 
            // btnLiveData
            // 
            this.btnLiveData.Location = new System.Drawing.Point(12, 12);
            this.btnLiveData.Name = "btnLiveData";
            this.btnLiveData.Size = new System.Drawing.Size(152, 52);
            this.btnLiveData.TabIndex = 1;
            this.btnLiveData.Text = "Live Data";
            this.btnLiveData.UseVisualStyleBackColor = true;
            this.btnLiveData.Click += new System.EventHandler(this.btnLiveData_Click);
            // 
            // btnSaveText
            // 
            this.btnSaveText.Location = new System.Drawing.Point(621, 12);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(152, 52);
            this.btnSaveText.TabIndex = 2;
            this.btnSaveText.Text = "Save to Text";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(215, 12);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(116, 52);
            this.btnChoosePath.TabIndex = 3;
            this.btnChoosePath.Text = "Choose Path";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(337, 32);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(207, 20);
            this.textBoxPath.TabIndex = 4;
            // 
            // btnGenQR
            // 
            this.btnGenQR.Location = new System.Drawing.Point(633, 514);
            this.btnGenQR.Name = "btnGenQR";
            this.btnGenQR.Size = new System.Drawing.Size(140, 41);
            this.btnGenQR.TabIndex = 5;
            this.btnGenQR.Text = "Generate QR Code";
            this.btnGenQR.UseVisualStyleBackColor = true;
            this.btnGenQR.Click += new System.EventHandler(this.btnGenQR_Click);
            // 
            // btnQRDecode
            // 
            this.btnQRDecode.Location = new System.Drawing.Point(464, 514);
            this.btnQRDecode.Name = "btnQRDecode";
            this.btnQRDecode.Size = new System.Drawing.Size(125, 41);
            this.btnQRDecode.TabIndex = 6;
            this.btnQRDecode.Text = "Decode QR Code";
            this.btnQRDecode.UseVisualStyleBackColor = true;
            this.btnQRDecode.Click += new System.EventHandler(this.btnQRDecode_Click);
            // 
            // Retrieve_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 567);
            this.Controls.Add(this.btnQRDecode);
            this.Controls.Add(this.btnGenQR);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.btnSaveText);
            this.Controls.Add(this.btnLiveData);
            this.Controls.Add(this.textBoxShowData);
            this.Name = "Retrieve_Screen";
            this.Text = "Retrieve Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxShowData;
        private System.Windows.Forms.Button btnLiveData;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnGenQR;
        private System.Windows.Forms.Button btnQRDecode;
    }
}

