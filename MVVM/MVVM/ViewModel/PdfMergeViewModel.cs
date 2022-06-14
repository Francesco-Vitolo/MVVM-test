using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    class PdfMergeViewModel
    {
        public RelayCommand Merge { get; set; }

        public PdfMergeViewModel()
        {
            Merge = new RelayCommand(o =>
            {
                string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\test";
                string newFile = $@"{path}\merged.pdf";
                string[] PdfFiles = Directory.GetFiles(path, "*.pdf", SearchOption.TopDirectoryOnly);
                PdfDocument document = new PdfDocument();

                foreach (string pdfFile in PdfFiles)
                {
                    PdfDocument inputPDFDocument = PdfReader.Open(pdfFile, PdfDocumentOpenMode.Import);
                    document.Version = inputPDFDocument.Version;
                    foreach (PdfPage page in inputPDFDocument.Pages)
                    {
                        document.AddPage(page);
                    }
                }
                if (File.Exists(newFile))
                {
                    File.Delete(newFile);
                }
                document.Save(newFile);
            });
        }
    }
}
