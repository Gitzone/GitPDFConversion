using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using System.Diagnostics;
using Conversion;
namespace PDFConversion
{
    /// <summary>
    /// Summary description for Handler
    /// </summary>
    public class Handler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            PdfDocument doc = new PdfDocument();
            string exportPath = context.Server.MapPath("Uploads");
            string tempUploadFolder = context.Server.MapPath("TempFolder");
            for (int i = 0; i < context.Request.Files.Count; i++)
            {

                //    PdfPage page = doc.AddPage();
                HttpPostedFile hpf = context.Request.Files[i] as HttpPostedFile;
                string FileName = string.Empty;

                if (HttpContext.Current.Request.Browser.Browser.ToUpper() == "IE")
                {
                    string[] files = hpf.FileName.Split(new char[] { '\\' });
                    FileName = files[files.Length - 1];
                }
                else
                {
                    FileName = hpf.FileName;
                }
                if (hpf.ContentLength == 0)
                    continue;


                string savedFileName = string.Format("{0}\\{1}", tempUploadFolder, FileName);
                hpf.SaveAs(savedFileName);

                string extension = Path.GetExtension(FileName).ToLower();
                int pageNumber=i++;
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".gif")
                {
                    Conversion.PDFConversion.ConvertTOPdf("IMAGE", savedFileName, exportPath, ref doc, i);
                }
                //else if (extension == ".xls" || extension == ".xlsx")
                //{
                //    Conversion.PDFConversion.ConvertTOPdf("EXCEL");
                //}
                //else if (extension == ".txt")
                //{
                //    Conversion.PDFConversion.ConvertTOPdf("TEXT");
                //}
                //else if (extension == ".doc" || extension == ".docx")
                //{
                //    Conversion.PDFConversion.ConvertTOPdf("DOC");
                //}



            }

            //Save the document...
            string filename = @"C:\Users\Lucky s\Desktop\New folder (2)\HelloWorld.pdf";
           // doc.Save(filename);
            doc.Close();
            //Delete all files from temprary folder
            //Array.ForEach(Directory.GetFiles(tempUploadFolder), File.Delete);

            //// ...and start a viewer.
            Process.Start(filename);
            context.Response.Write("Hello World");

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}