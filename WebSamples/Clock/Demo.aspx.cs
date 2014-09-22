using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Web.UI;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;

namespace PDFsharpClock
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //convero();
           // DocToPdf();
            ExcelToPDF();
            //try
            //{
            //    string line = null;
            //    System.IO.TextReader readFile = new StreamReader(@"D:\HelpFul\Pdf Convertor\PDFsharp\samples\WebSamples\Clock\DRAFTBOARD.xlsx");
            //    int yPoint = 0;

            //    PdfDocument pdf = new PdfDocument();
            //    pdf.Info.Title = "TXT to PDF";
            //    PdfPage pdfPage = pdf.AddPage();
            //    XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            //    XFont font = new XFont("Verdana", 20, XFontStyle.Regular);

            //    while (true)
            //    {
            //        line = readFile.ReadLine();
            //        if (line == null)
            //        {
            //            break; // TODO: might not be correct. Was : Exit While
            //        }
            //        else
            //        {
            //            graph.DrawString(line, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            //            yPoint = yPoint + 40;
            //        }
            //    }

            //    //  string pdfFilename = @"D:\HelpFul\Pdf Convertor\PDFsharp\samples\WebSamples\Clock\txttopdf.pdf";
            //    string pdfFilename = @"D:\HelpFul\Pdf Convertor\PDFsharp\samples\WebSamples\Clock\xlstopdf.pdf";
            //    pdf.Save(pdfFilename);
            //    readFile.Close();
            //    readFile = null;
            //    Process.Start(pdfFilename);
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show(ex.ToString());
            //}

        }

        void DocToPdf()
        {
           
            // Create a new Microsoft Word application object
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            // C# doesn't have optional arguments so we'll need a dummy value
            object oMissing = System.Reflection.Missing.Value;

            // Get list of Word files in specified directory
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\Lucky s\Desktop\New folder (2)");
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








            //Application ap = new Application();
            //try
            //{

            //    Document doc = ap.Documents.Open(@"D:\HelpFul\Pdf Convertor\PDFsharp\samples\WebSamples\Clock\test.docx", ReadOnly: false, Visible: false);
            //    doc.Activate();

            //    Selection sel = ap.Selection;

            //    if (sel != null)
            //    {
            //        switch (sel.Type)
            //        {
            //            case WdSelectionType.wdSelectionIP:
            //                sel.TypeText(DateTime.Now.ToString());
            //                sel.TypeParagraph();
            //                break;

            //            default:
            //                Console.WriteLine("Selection type not handled; no writing done");
            //                break;

            //        }

            //        // Remove all meta data.
            //        doc.RemoveDocumentInformation(WdRemoveDocInfoType.wdRDIAll);

            //        ap.Documents.Save(NoPrompt: true, OriginalFormat: true);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Unable to acquire Selection...no writing to document done..");
            //    }

            //    ap.Documents.Close(SaveChanges: false, OriginalFormat: false, RouteDocument: false);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception Caught: " + ex.Message); // Could be that the document is already open (/) or Word is in Memory(?)
            //}
            //finally
            //{
            //    // Ambiguity between method 'Microsoft.Office.Interop.Word._Application.Quit(ref object, ref object, ref object)' and non-method 'Microsoft.Office.Interop.Word.ApplicationEvents4_Event.Quit'. Using method group.
            //    // ap.Quit( SaveChanges: false, OriginalFormat: false, RouteDocument: false );
            //    ((_Application)ap).Quit(SaveChanges: false, OriginalFormat: false, RouteDocument: false);

            //    System.Runtime.InteropServices.Marshal.ReleaseComObject(ap);
            //}
        }

        void ExcelToPDF()
        {
            Microsoft.Office.Interop.Excel.ApplicationClass excelApplication = new Microsoft.Office.Interop.Excel.ApplicationClass();
            Workbook excelWorkBook = null;
            string paramSourceBookPath = @"C:\Users\Lucky s\Desktop\New folder (2)\DRAFTBOARD.xlsx";
            object paramMissing = Type.Missing;
            string paramExportFilePath = @"C:\Users\Lucky s\Desktop\New folder (2)\Test.pdf";
            XlFixedFormatType paramExportFormat = XlFixedFormatType.xlTypePDF;
            XlFixedFormatQuality paramExportQuality =
                XlFixedFormatQuality.xlQualityStandard;
            bool paramOpenAfterPublish = true;
            bool paramIncludeDocProps = false;
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



        void convero()
        {

            // Create a new Microsoft Word application object
            Microsoft.Office.Interop.Excel.ApplicationClass _excelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();

            // C# doesn't have optional arguments so we'll need a dummy value
            object oMissing = System.Reflection.Missing.Value;

            // Get list of Word files in specified directory
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\Lucky s\Desktop\New folder (2)");
            FileInfo[] wordFiles = dirInfo.GetFiles("*.xlsx");

            _excelApp.Visible = false;
            _excelApp.DisplayAlerts = false;
            //_excelApp.ScreenUpdating;
            string fileName1 = @"C:\Users\Lucky s\Desktop\New folder (2)\DRAFTBOARD.xlsx";
            string outName1 = @"C:\Users\Lucky s\Desktop\New folder (2)\DRAFTBOARD.Pdf";

            foreach (FileInfo wordFile in wordFiles)
            {
                // Cast as Object for word Open method
               // Object filename = (Object)wordFile.FullName;
                Object filename = (Object)fileName1;
                
                // Use the dummy value as a placeholder for optional arguments
                Workbook doc = _excelApp.Workbooks.Open(fileName1, oMissing,
                    false,oMissing,oMissing,oMissing,oMissing,
                    oMissing, oMissing, oMissing,oMissing, true,
                    oMissing, oMissing);
               doc.Activate();

               object outputFileName = fileName1.Replace(".xlsx", ".pdf");
                object fileFormat = WdSaveFormat.wdFormatPDF;

                // Save document into PDF Format
                doc.SaveAs(outName1,
                    fileFormat, oMissing, oMissing,
                    true, false, XlSaveAsAccessMode.xlNoChange, false,
                    oMissing, oMissing,oMissing, oMissing);

                // Close the Word document, but leave the Word application open.
                // doc has to be cast to type _Document so that it will find the
                // correct Close method.                
                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                ((_Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
                doc = null;
            }

            // word has to be cast to type _Application so that it will find
            // the correct Quit method.
            ((Microsoft.Office.Interop.Excel._Application)_excelApp).Quit();
            _excelApp = null;
        }


        //public static void ConvertExcelToPdf(string excelFileIn, string pdfFileOut)
        //{
        //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        //   // msExcel.Application excel = new msExcel.Application();
        //    try
        //    {
        //        excel.Visible = false;
        //        excel.ScreenUpdating = false;
        //        excel.DisplayAlerts = false;

        //        FileInfo excelFile = new FileInfo(excelFileIn);

        //        string filename = excelFile.FullName;

        //        Microsoft.Office.Interop.Excel.Workbook wbk = excel.Workbooks.Open(filename, missing,
        //            missing, missing, missing, missing, missing,
        //            missing, missing, missing, missing, missing,
        //            missing, missing, missing);
        //        wbk.Activate();

        //        object outputFileName = pdfFileOut;
        //        msExcel.XlFixedFormatType fileFormat = msExcel.XlFixedFormatType.xlTypePDF;

        //        // Save document into PDF Format
        //        wbk.ExportAsFixedFormat(fileFormat, outputFileName,
        //            missing, missing, missing,
        //            missing, missing, missing,
        //            missing);

        //        object saveChanges = msExcel.XlSaveAction.xlDoNotSaveChanges;
        //        ((msExcel._Workbook)wbk).Close(saveChanges, missing, missing);
        //        wbk = null;
        //    }
        //    finally
        //    {
        //        ((msExcel._Application)excel).Quit();
        //        excel = null;
        //    }
        //}


       








    }
}