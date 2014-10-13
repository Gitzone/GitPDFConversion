using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Conversion;
using PdfSharp.Pdf;
using PDFConversionAPP.ServiceReference1;
using System.ServiceModel;

namespace PDFConversionAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter =
"CSV Files (*.csv)|*.csv|" +
"Excel Files (*.xls)|*.xls";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                lblFileNames.Text = openFileDialog1.FileName;

            }

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {


            /**Progress Bar***/
            progressBar1.Enabled = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 100;
            progressBar1.Step = 10;
            progressBar1.PerformStep();
            /**End**/

            BasicHttpBinding binding = new BasicHttpBinding();
            binding.MaxBufferPoolSize = 2147483647;
            binding.MaxBufferSize = 2147483647;
            binding.MaxReceivedMessageSize = 2147483647;
            string url = System.Configuration.ConfigurationSettings.AppSettings["webserviceURL"];
            EndpointAddress address = new EndpointAddress(url);

            Service1SoapClient sc = new Service1SoapClient(binding, address);




            PdfDocument doc = new PdfDocument();
            int count = 0;
            string[] FilenameName;
            string exportPath="";
            /***Final Output file folder***/
            if (lblOutpath.Text == "")
            {
                string appPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                exportPath = appPath + "\\Uploads";
                bool exists = System.IO.Directory.Exists(exportPath);
                if (!exists)
                    System.IO.Directory.CreateDirectory(exportPath);
            }
            else
            {
                exportPath = lblOutpath.Text;
            }
            /****End***/


            progressBar1.PerformStep();

            foreach (string item in openFileDialog1.FileNames)
            {

                FilenameName = item.Split('\\');
                string extension = Path.GetExtension(FilenameName[FilenameName.Length - 1]).ToLower();
                string fullfilename = Path.GetFileName(FilenameName[FilenameName.Length - 1]);
                string[] filename = fullfilename.Split('.');
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".gif")
                {

                    ConvertFileToStream("IMAGE", item);
                }
                else if (extension == ".xls" || extension == ".xlsx")
                {
                    ConvertFileToStream("EXCEL", item);
                }
                else if (extension == ".txt")
                {
                    ConvertFileToStream("TEXT", item);
                }
                else if (extension == ".doc" || extension == ".docx")
                {
                    ConvertFileToStream("DOC", item);
                }
                count++;
                progressBar1.PerformStep();
            }
            progressBar1.PerformStep();
            Conversion.PDFConversion con = new PDFConversion();


            var documentContents = sc.MergDocuments();
            saveFinalDocuments(documentContents, exportPath);

            progressBar1.Value = 100;
            progressBar1.Enabled = false;
            progressBar1.PerformStep();
            MessageBox.Show("File Created on location:" + exportPath);

        }

        private void ConvertFileToStream(string docType, string sFile)
        {
            try
            {
                Service1SoapClient sc = new Service1SoapClient();
                FileStream objfilestream = new FileStream(sFile, FileMode.Open, FileAccess.Read);
                int len = (int)objfilestream.Length;
                Byte[] mybytearray = new Byte[len];
                objfilestream.Read(mybytearray, 0, len);
                sc.SaveDocument(mybytearray, sFile.Remove(0, sFile.LastIndexOf("\\") + 1), docType);
                objfilestream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in file:" + sFile);
                //throw;
            }
            
        }

        private void saveFinalDocuments(byte[] documentContents, string exportPath)
        {
           // string datetimeString = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);
            string datetimeString = "lucky";
            string sFile = exportPath + "\\" + datetimeString + ".pdf";
            MemoryStream objstreaminput = new MemoryStream();
            FileStream objfilestream = new FileStream(sFile.Insert(sFile.LastIndexOf("."), "2"), FileMode.Create, FileAccess.ReadWrite);


            int len = documentContents.Length;
            Byte[] mybytearray = new Byte[len];
            objfilestream.Write(documentContents, 0, len);
            objfilestream.Close();
        }


        private void btnOutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OpenFilePath = new FolderBrowserDialog();
            DialogResult result = OpenFilePath.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                lblOutpath.Text = OpenFilePath.SelectedPath;

            }

        }

    }
}
