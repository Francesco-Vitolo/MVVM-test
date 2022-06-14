using System;
using Spire.Pdf;

namespace MVVM.ViewModel
{
    class PdfToWordViewModel
    {
        public RelayCommand CmdPdfToWord { get; set; }
        public PdfToWordViewModel()
        {
            CmdPdfToWord = new RelayCommand(o =>
            {
                string filepath = Files.SelectPdf();
                if (filepath != null)
                {
                    PdfDocument doc = new PdfDocument();
                    doc.LoadFromFile(filepath);
                    doc.SaveToFile($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Converted.docx", FileFormat.DOCX);
                }
            });
        }
    }
}
