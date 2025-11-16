namespace CodeQrGenerator
{
    partial class Form1
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
            QRCodeBox = new PictureBox();
            GenerateQRButton = new Button();
            TextBoxQRCode = new TextBox();
            DownloadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)QRCodeBox).BeginInit();
            SuspendLayout();
            // 
            // QRCodeBox
            // 
            QRCodeBox.BackColor = SystemColors.HighlightText;
            QRCodeBox.Location = new Point(77, 33);
            QRCodeBox.Name = "QRCodeBox";
            QRCodeBox.Size = new Size(389, 274);
            QRCodeBox.SizeMode = PictureBoxSizeMode.Zoom;
            QRCodeBox.TabIndex = 0;
            QRCodeBox.TabStop = false;
            // 
            // GenerateQRButton
            // 
            GenerateQRButton.Location = new Point(77, 368);
            GenerateQRButton.Name = "GenerateQRButton";
            GenerateQRButton.Size = new Size(197, 43);
            GenerateQRButton.TabIndex = 1;
            GenerateQRButton.Text = "Gerar QR Code";
            GenerateQRButton.UseVisualStyleBackColor = true;
            GenerateQRButton.Click += GenerateQRButton_Click;
            // 
            // TextBoxQRCode
            // 
            TextBoxQRCode.Location = new Point(77, 328);
            TextBoxQRCode.Name = "TextBoxQRCode";
            TextBoxQRCode.Size = new Size(389, 23);
            TextBoxQRCode.TabIndex = 2;
            TextBoxQRCode.Text = "QR Code Data...";
            // 
            // DownloadButton
            // 
            DownloadButton.Location = new Point(289, 368);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(177, 43);
            DownloadButton.TabIndex = 3;
            DownloadButton.Text = "Download QR Code";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += DownloadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(563, 433);
            Controls.Add(DownloadButton);
            Controls.Add(TextBoxQRCode);
            Controls.Add(GenerateQRButton);
            Controls.Add(QRCodeBox);
            Name = "Form1";
            Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)QRCodeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox QRCodeBox;
        private Button GenerateQRButton;
        private TextBox TextBoxQRCode;
        private Button DownloadButton;
    }
}
