using System;
using System.Runtime.InteropServices;

namespace CodeQrGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly Guid DownloadsFolderGuid = new Guid("374DE290-123F-4565-9164-39C4925E467B");

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        private static extern int SHGetKnownFolderPath(
            [MarshalAs(UnmanagedType.LPStruct)] Guid rfid,
            uint dwFlags,
            IntPtr hToken,
            out IntPtr ppszPath
        );

        public static string GetDownloadsPath()
        {
            IntPtr ppszPath;
            int hr = SHGetKnownFolderPath(DownloadsFolderGuid, 0, IntPtr.Zero, out ppszPath);

            if (hr != 0)
                throw new ExternalException("Erro ao obter o caminho da pasta Downloads", hr);

            string path = Marshal.PtrToStringUni(ppszPath);
            Marshal.FreeCoTaskMem(ppszPath);

            return path;
        }
        private void GenerateQRButton_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
            var QRData = QRgen.CreateQrCode(TextBoxQRCode.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var QRCode = new QRCoder.QRCode(QRData);

            QRCodeBox.Image = QRCode.GetGraphic(50);
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (TextBoxQRCode.Text == null || TextBoxQRCode.Text == "" || TextBoxQRCode.Text == "QR Code Data...")
            {
                MessageBox.Show("Gere um QR code válido para baixar!");
                return;
            }

            try
            {
                var downloadsPath = GetDownloadsPath();
                var fileName = Path.Combine(downloadsPath, "qrcode.png");

                QRCodeBox.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                
                MessageBox.Show("QR Code Salvo com sucesso!");
            }
            catch (Exception ex) 
            {

                MessageBox.Show("Erro ao fazer download!");
            }

        }
        
    }
}
