using System;
using System.Windows.Forms;

namespace MVVM.ViewModel
{
    public static class Files
    {
        private const string DialogFilterPDF = "Pdf Files|*.pdf";

        public static string SelectPdf()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = DialogFilterPDF;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
    }
}
