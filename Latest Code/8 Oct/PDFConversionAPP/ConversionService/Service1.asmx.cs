using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using PdfSharp.Pdf.IO;
using iTextSharp;
using Conversion;
namespace ConversionService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {



        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public void ConvertTOPdf(string Type, string sourcePath, string ExportPath)
        {

           PDFConversion.ConvertTOPdf(Type, sourcePath, ExportPath);
            //switch (Type)
            //{
            //    case "EXCEL":
            //        ExcelToPDF(sourcePath, ExportPath);
            //        break;
            //    case "TEXT":
            //        TextToPdf(sourcePath, ExportPath);
            //        break;
            //    case "DOC":
            //        DocToPdf(sourcePath, ExportPath);
            //        break;
            //    case "IMAGE":
            //        ImageToPDF(sourcePath, ExportPath);
            //        break;
            //    default:
            //        break;
            //}



        }

        [WebMethod]
        public bool SaveDocument(Byte[] docbinaryarray, string docname, string docType)
        {
            //try
            //{
                /***Create Temp folder just processing purpose*/
                string strdocPath = Server.MapPath("Temp"); // your code goes here
                bool checkfolder = System.IO.Directory.Exists(strdocPath);
                if (!checkfolder)
                    System.IO.Directory.CreateDirectory(strdocPath);
                /*****End****/

                strdocPath = strdocPath+ "\\" + docname;
                FileStream objfilestream = new FileStream(strdocPath, FileMode.Create, FileAccess.ReadWrite);
                objfilestream.Write(docbinaryarray, 0, docbinaryarray.Length);
                objfilestream.Close();


                string[] file = strdocPath.Split('.');
                string PdfFile = file[0];
                if (docType != "pdf")
                {
                    PDFConversion.ConvertTOPdf(docType, strdocPath, PdfFile);
                    File.Delete(strdocPath);
                }
               
                return true;

            //}
            //catch (Exception)
            //{
            //    return true;
            //    //throw;
            //}

            
        }

        [WebMethod]

        public Byte[] MergDocuments()
        {
            string strdocPath =Server.MapPath("Temp");
            /***Create Temp folder just processing purpose*/
            string outputPath =Server.MapPath("Output"); // your code goes here
            bool checkfolder = System.IO.Directory.Exists(outputPath);
            if (!checkfolder)
                System.IO.Directory.CreateDirectory(outputPath);
            /*****End****/
            Byte[] documentcontent = PDFConversion.PDfMer(strdocPath, outputPath);
            Directory.Delete(strdocPath, true);
            Directory.Delete(outputPath,true);
            return documentcontent;
        }

        [WebMethod]
        public int GetDocumentLen(string DocumentName)
        {
          return  PDFConversion.GetDocumentLen(DocumentName);
        }


    }
}