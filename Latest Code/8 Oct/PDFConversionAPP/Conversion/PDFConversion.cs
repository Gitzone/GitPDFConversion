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
using PdfSharp.Pdf.IO;
using iTextSharp;




namespace Conversion
{
    public class PDFConversion
    {
        public static void ConvertTOPdf(string Type, string sourcePath, string ExportPath)
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
                    ImageToPDF(sourcePath, ExportPath);
                    break;
                default:
                    break;
            }



        }
        static void ImageToPDF(string sourcePath, string ExportPath)
        {
            PdfDocument doc = new PdfDocument();
            doc.Pages.Add(new PdfPage());
            XGraphics xgr = XGraphics.FromPdfPage(doc.Pages[0]);
            XImage img = XImage.FromFile(sourcePath); //@"C:\Users\Lucky s\Desktop\New folder (2)\you-words.gif"

            xgr.DrawImage(img, 0, 0);
            doc.Save(ExportPath + ".pdf"); //@"C:\Users\Lucky s\Desktop\New folder (2)\ImgToPDF.pdf"
            doc.Close();
            img.Dispose();
            xgr.Dispose();
        }
        static void TextToPdf(string sourcePath, string ExportPath)
        {
            try
            {
                string line = null;
                System.IO.TextReader readFile = new StreamReader(sourcePath); //@"D:\HelpFul\Pdf Convertor\PDFsharp\samples\WebSamples\Clock\DRAFTBOARD.xlsx"
                int yPoint = 0;
                PdfDocument doc = new PdfDocument();
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "TXT to PDF";
                PdfPage pdfPage = doc.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);

                XFont font = new XFont("Verdana", 12, XFontStyle.Regular);

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
                doc.Save(pdfFilename + ".pdf");
                readFile.Close();
                readFile = null;
                // Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }
        static void DocToPdf(string sourcePath, string ExportPath)
        {


            // Create a new Microsoft Word application object
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            // C# doesn't have optional arguments so we'll need a dummy value
            object oMissing = System.Reflection.Missing.Value;


            word.Visible = false;
            word.ScreenUpdating = false;


            Object filename = (Object)sourcePath;

            // Use the dummy value as a placeholder for optional arguments
            Document doc = word.Documents.Open(ref filename, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            doc.Activate();

            object outputFileName = ExportPath; //sourcePath.Replace(".docx", ".pdf");
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


            // word has to be cast to type _Application so that it will find
            // the correct Quit method.
            ((Microsoft.Office.Interop.Word._Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
            word = null;

        }
        static void ExcelToPDF(string sourcePath, string ExportPath)
        {
            //int i = 9;
            //int d = 0;
            //decimal s = i / d;

            Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
          
            Workbook excelWorkBook = null;

            string paramSourceBookPath = sourcePath;
            object paramMissing = Type.Missing;
            string paramExportFilePath = ExportPath;// @"C:\Users\Lucky s\Desktop\New folder (2)\Test.pdf";
            XlFixedFormatType paramExportFormat = XlFixedFormatType.xlTypePDF;
            XlFixedFormatQuality paramExportQuality =
                XlFixedFormatQuality.xlQualityStandard;
            bool paramOpenAfterPublish = false;
            bool paramIncludeDocProps = true;
            bool paramIgnorePrintAreas = false;
            object paramFromPage = Type.Missing;
            object paramToPage = Type.Missing;
            object oMissing = System.Reflection.Missing.Value;
            // XlSaveAsAccessMode Mode = XlSaveAsAccessMode.xl;
            // excelWorkBook.Application.DisplayAlerts = false;
            try
            {
                // Open the source workbook.
                excelWorkBook = excelApplication.Workbooks.Open(paramSourceBookPath,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing);
                excelWorkBook.Activate();
                //Formating
                Worksheet sheet = excelWorkBook.Worksheets[1];
                sheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                // Zoom property must be false, otherwise the "FitToPages" properties 
                // are ignored.
                sheet.PageSetup.Zoom = false;

                // these set the number of pages tall or wide the worksheet will be 
                // scaled to when printed.
                sheet.PageSetup.FitToPagesTall = 1;
                sheet.PageSetup.FitToPagesWide = 1;
                // sheet.DisplayPageBreaks = true;
                sheet.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
                sheet.UsedRange.Font.Size = 14;
                //sheet.UsedRange.Borders.Weight = 2;
                //sheet.UsedRange.Cells.Borders.Weight = 2;

                sheet.UsedRange.Font.Name = "Arial Narrow";
                sheet.PageSetup.LeftMargin = 0.5;
                sheet.PageSetup.RightMargin = 0.5;
                sheet.PageSetup.TopMargin = 1;
                sheet.PageSetup.BottomMargin = 0.5;
                //End


                // Save it in the target format.
                if (excelWorkBook != null)

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
                Process excelProcess = Process.GetProcessesByName("EXCEL")[0];
                if (!excelProcess.CloseMainWindow())
                {
                    excelProcess.Kill();
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        public static byte[] PDfMer(string ExportPath, string outFilePath)
        {
            String[] files = Directory.GetFiles(ExportPath);  //@"C:\Users\Lucky s\Desktop\New folder (2)\Doc\Tips1-Message from FB Engineer.pdf,C:\Users\Lucky s\Desktop\New folder (2)\HelloWorld.pdf".Split(',');
            string outFile = outFilePath + "\\" + Guid.NewGuid() + ".pdf"; //strdocPath
            if (files.Count() > 0)
            {
                MergeFiles(outFile, ExportPath);
                var documentContents = GetOutputDocument(outFile);
                return documentContents;
            }
            else
            {
                Byte[] empty=new Byte[0];
                return empty;
            }
        }
        private static void MergeFiles(string destinationFile, string ExportPath)
        {
            #region old code
            //        if (System.IO.File.Exists(destinationFile))
            //            System.IO.File.Delete(destinationFile);

            //        string[] sSrcFile;
            //        sSrcFile = new string[sourceFiles.Count()];

            //        string[] arr = new string[sourceFiles.Count()];
            //        for (int i = 0; i <= sourceFiles.Length - 1; i++)
            //        {
            //            if (sourceFiles[i] != null)
            //            {
            //                if (sourceFiles[i].Trim() != "")
            //                    arr[i] = sourceFiles[i].ToString();
            //            }
            //        }

            //        if (arr != null)
            //        {
            //            sSrcFile = new string[sourceFiles.Count()];

            //            for (int ic = 0; ic <= arr.Length - 1; ic++)
            //            {
            //                sSrcFile[ic] = arr[ic].ToString();
            //            }
            //        }
            //        try
            //        {
            //            int f = 0;

            //            using (iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4))
            //            {

            //                iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(destinationFile, FileMode.Create));

            //                document.Open();
            //                iTextSharp.text.pdf.PdfContentByte cb = writer.DirectContent;
            //                iTextSharp.text.pdf.PdfImportedPage page;

            //                int rotation;
            //                while (f < sSrcFile.Length)
            //                {

            //                    iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(sSrcFile[f]);
            //                    int n = reader.NumberOfPages;
            //                    int i = 0;
            //                    while (i < n)
            //                    {
            //                        i++;

            //                        document.SetPageSize(iTextSharp.text.PageSize.A4);
            //                        document.NewPage();
            //                        page = writer.GetImportedPage(reader, i);

            //                        rotation = reader.GetPageRotation(i);
            //                        if (rotation == 90 || rotation == 270)
            //                        {
            //                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
            //                        }
            //                        else
            //                        {
            //                            cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
            //                        }
            //                    }

            //                    f++;
            //                   // reader.Dispose();
            //                    //if (f < sSrcFile.Length)
            //                    //{

            //                    //    reader = new iTextSharp.text.pdf.PdfReader(sSrcFile[f]);
            //                    //    n = reader.NumberOfPages;

            //                    //}



            //                }

            //                document.Close();

            //                // reader.Close();
            //               //  reader.Dispose();
            //            }
            //           // reader.Close();
            //           // reader.Dispose();
            //           //reader = new PdfReader();
            //           // sSrcFile= new string[0];
            //        }

            //        catch (Exception e)
            //        {
            //            // Response.Write(e.Message);
            //        }


            //    }


            //}
            #endregion

            #region new code

            using (FileStream stream = new FileStream(destinationFile, FileMode.Create))
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                iTextSharp.text.pdf.PdfCopy pdf = new iTextSharp.text.pdf.PdfCopy(pdfDoc, stream);
                pdfDoc.Open();
                var files = Directory.GetFiles(ExportPath);

                int i = 1;
                foreach (string file in files)
                {
                   // MemoryStream content= new MemoryStream(
                    var reader = new iTextSharp.text.pdf.PdfReader(file);
                    pdf.AddDocument(reader);
                    i++;
                    reader.Close();
                }

                if (pdfDoc != null)
                    pdfDoc.Close();

            }

            #endregion
        }

        //Get Pdf document
        public static byte[] GetOutputDocument(string outFileName)
        {
            string strdocPath;
            strdocPath = outFileName;

            FileStream objfilestream = new FileStream(strdocPath, FileMode.Open, FileAccess.Read);
            int len = (int)objfilestream.Length;
            Byte[] documentcontents = new Byte[len];
            objfilestream.Read(documentcontents, 0, len);
            objfilestream.Close();

            return documentcontents;
        }

        //Get Length of document

        public static int GetDocumentLen(string DocumentName)
        {
            FileStream objfilestream = new FileStream(DocumentName, FileMode.Open, FileAccess.Read);
            int len = (int)objfilestream.Length;
            objfilestream.Close();

            return len;
        } 

    }

}
