using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;



namespace Conversion
{
    public class PDFConversion
    {
        public static void ConvertTOPdf(string Type, string sourcePath, string ExportPath, ref PdfDocument doc)
        {
            switch (Type)
            {
                case "EXCEL":
                    ExcelToPDF(sourcePath, ExportPath);
                    break;
                case "TEXT":
                    TextToPdf(sourcePath, ExportPath);
                    break;
                case "DOC":
                    DocToPdf(sourcePath, ExportPath);
                    break;
                case "IMAGE":
                    ImageToPDF(sourcePath, ExportPath,ref doc);
                    break;
                default:
                    break;
            }
           
        }


        static void ImageToPDF(string sourcePath, string ExportPath, ref PdfDocument doc)
        {
            //PdfDocument doc = new PdfDocument();
            doc.Pages.Add(new PdfPage());
            XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[0]);
            XImage img = XImage.FromFile(sourcePath); //@"C:\Users\Lucky s\Desktop\New folder (2)\you-words.gif"

            xgr.DrawImage(img, 0, 0);
            doc.Save(@"C:\Users\Lucky s\Desktop\New folder (2)\HelloWorld.pdf"); //@"C:\Users\Lucky s\Desktop\New folder (2)\ImgToPDF.pdf"
            //doc.Close();
        }

        static void DocToPdf(string sourcePath, string ExportPath)
        {
            // Create a new Microsoft Word application object
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            // C# doesn't have optional arguments so we'll need a dummy value
            object oMissing = System.Reflection.Missing.Value;

            // Get list of Word files in specified directory
            DirectoryInfo dirInfo = new DirectoryInfo(sourcePath); //@"C:\Users\Lucky s\Desktop\New folder (2)"
            FileInfo[] wordFiles = dirInfo.GetFiles("*.doc");

            word.Visible = false;
            word.ScreenUpdating = false;

            foreach (FileInfo wordFile in wordFiles)
            {
                // Cast as Object for word Open method
                Object filename = (Object)wordFile.FullName;

                // Use the dummy value as a placeholder for optional arguments
                Document doc = word.Documents.Open(ref filename, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                doc.Activate();

                object outputFileName = wordFile.FullName.Replace(".doc", ".pdf");
                object fileFormat = WdSaveFormat.wdFormatPDF;

                // Save document into PDF Format
                doc.SaveAs(ref outputFileName,
                    ref fileFormat, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                // Close the Word document, but leave the Word application open.
                // doc has to be cast to type _Document so that it will find the
                // correct Close method.                
                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                ((_Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
                doc = null;
            }

            // word has to be cast to type _Application so that it will find
            // the correct Quit method.
            ((Microsoft.Office.Interop.Word._Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
            word = null;

        }

        static void TextToPdf(string sourcePath, string ExportPath)
        {
            try
            {
                string line = null;
                System.IO.TextReader readFile = new StreamReader(sourcePath); //@"D:\HelpFul\Pdf Convertor\PDFsharp\samples\WebSamples\Clock\DRAFTBOARD.xlsx"
                int yPoint = 0;

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "TXT to PDF";
                PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 20, XFontStyle.Regular);

                while (true)
                {
                    line = readFile.ReadLine();
                    if (line == null)
                    {
                        break; // TODO: might not be correct. Was : Exit While
                    }
                    else
                    {
                        graph.DrawString(line, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                        yPoint = yPoint + 40;
                    }
                }

                //  string pdfFilename = @"D:\HelpFul\Pdf Convertor\PDFsharp\samples\WebSamples\Clock\txttopdf.pdf";
                string pdfFilename = ExportPath; //@"D:\HelpFul\Pdf Convertor\PDFsharp\samples\WebSamples\Clock\xlstopdf.pdf";
                pdf.Save(pdfFilename);
                readFile.Close();
                readFile = null;
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }

        static void ExcelToPDF(string sourcePath, string ExportPath)
        {
            Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkBook = null;
            string paramSourceBookPath = sourcePath;//@"C:\Users\Lucky s\Desktop\New folder (2)\StocksOnTheMove.xls";
            object paramMissing = Type.Missing;
            string paramExportFilePath = ExportPath;// @"C:\Users\Lucky s\Desktop\New folder (2)\Test.pdf";
            XlFixedFormatType paramExportFormat = XlFixedFormatType.xlTypePDF;
            XlFixedFormatQuality paramExportQuality =
                XlFixedFormatQuality.xlQualityStandard;
            bool paramOpenAfterPublish = true;
            bool paramIncludeDocProps = true;
            bool paramIgnorePrintAreas = false;
            object paramFromPage = Type.Missing;
            object paramToPage = Type.Missing;
            object oMissing = System.Reflection.Missing.Value;
            // object Format=XlFixedFormatType

            XlSaveAsAccessMode Mode = XlSaveAsAccessMode.xlNoChange;
            //excelWorkBook.Application.DisplayAlerts = false;
            try
            {
                // Open the source workbook.
                excelWorkBook = excelApplication.Workbooks.Open(paramSourceBookPath,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing);
                excelWorkBook.Activate();
                // Save it in the target format.
                if (excelWorkBook != null)
                    //excelWorkBook.SaveAs(paramExportFilePath);
                    //  excelWorkBook.SaveAs(paramExportFilePath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);



                    excelWorkBook.ExportAsFixedFormat(paramExportFormat,
                        paramExportFilePath, paramExportQuality,
                        paramIncludeDocProps, paramIgnorePrintAreas, paramFromPage,
                        paramToPage, paramOpenAfterPublish,
                        paramMissing);
            }
            catch (Exception ex)
            {
                // Respond to the error.
            }
            finally
            {
                // Close the workbook object.
                if (excelWorkBook != null)
                {
                    excelWorkBook.Close(false, paramMissing, paramMissing);
                    excelWorkBook = null;
                }

                // Quit Excel and release the ApplicationClass object.
                if (excelApplication != null)
                {
                    excelApplication.Quit();
                    excelApplication = null;
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

    }



}
