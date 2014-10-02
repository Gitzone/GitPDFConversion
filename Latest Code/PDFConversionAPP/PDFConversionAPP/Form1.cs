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
            MessageBox.Show("Processing...");
            PdfDocument doc = new PdfDocument();
            int count = 0;
            string[] FilenameName;
            /***Final Output file folder***/
            string appPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string exportPath = appPath + "\\Uploads";
            bool exists = System.IO.Directory.Exists(exportPath);
            if (!exists)
                System.IO.Directory.CreateDirectory(exportPath);

            /****End***/

            /***Create Temp folder just processing purpose*/
            string tempPath = exportPath + "\\Temp"; // your code goes here
            bool checkfolder = System.IO.Directory.Exists(tempPath);
            if (checkfolder)
            {
                Directory.Delete(tempPath, true);
                checkfolder = false;

            }
                
            if (!checkfolder)
                System.IO.Directory.CreateDirectory(tempPath);
            /*****End****/


            foreach (string item in openFileDialog1.FileNames)
            {

                FilenameName = item.Split('\\');
                string extension = Path.GetExtension(FilenameName[FilenameName.Length - 1]).ToLower();
                string fullfilename = Path.GetFileName(FilenameName[FilenameName.Length - 1]);
                string[] filename = fullfilename.Split('.');
                string filePath = tempPath + "\\" + filename[0];
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".gif")
                {
                    Conversion.PDFConversion.ConvertTOPdf("IMAGE", item, filePath, ref doc, count);
                }
                else if (extension == ".xls" || extension == ".xlsx")
                {
                    Conversion.PDFConversion.ConvertTOPdf("EXCEL", item, filePath, ref doc, 0);
                }
                else if (extension == ".txt")
                {
                    Conversion.PDFConversion.ConvertTOPdf("TEXT", item, filePath, ref doc, count);
                }
                else if (extension == ".doc" || extension == ".docx")
                {
                    Conversion.PDFConversion.ConvertTOPdf("DOC", item, filePath, ref doc, 0);
                }
                count++;
            }
            Conversion.PDFConversion.PDfMer(tempPath, exportPath);
            MessageBox.Show(Convert.ToString(count) + " File(s) converted");


        }

    }
}
