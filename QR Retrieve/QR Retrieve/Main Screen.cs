using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using Newtonsoft.Json;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace QR_Retrieve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "fXXY9bR27PrxRtzxy6RJ9jpmEOcJOuSjJ5vZ6moR",
            BasePath = "https://qr-scan-papa-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(ifc);

                //SaveToFile();
                ChoosePath();
                LiveCall();
            }
            catch
            {
                MessageBox.Show("Check Internet Connection");
            }
        }

        private void btnLiveData_Click(object sender, EventArgs e)
        {
            LiveCall();
        }

        async void LiveCall()
        {
            while(true)
            {
                await Task.Delay(1000);
                FirebaseResponse res = await client.GetAsync(@"QRScanData");
                Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                PopulateRTB(data);
            }
        }

        void PopulateRTB(Dictionary<string,string> record)
        {
            textBoxShowData.Clear();
            foreach(var item in record)
            {
                textBoxShowData.Text += item.Value + "\n";
            }
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            SaveToFile();
            
        }

        async void SaveToFile()
        {
            while (true)
            {
                await Task.Delay(1000);

                //string filePath = @"D:\QR-Scan-Papa\Output.txt";
                string filePath = textBoxPath.Text + @"\Ouput.txt";

                File.WriteAllText(filePath, "");
                File.WriteAllText(filePath, textBoxShowData.Text);
            }
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            ChoosePath();
        }

        void ChoosePath()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxPath.Text = dialog.FileName;
            }

            else
            {
                textBoxPath.Text = "D:";
            }

            SaveToFile();
        }
    }
}
