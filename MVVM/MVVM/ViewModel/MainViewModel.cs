using MVVM.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand OpenHome { get; set; }
        public RelayCommand OpenPdfMerge { get; set; }
        public RelayCommand OpenPdfToWord { get; set; }
        public RelayCommand ExitCmd { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public PdfMergeViewModel PdfMergeVM { get; set; }
        public PdfToWordViewModel PdfToWordVM { get; set; }

        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CurrentView = HomeVM;

            OpenHome = new RelayCommand(o =>
            {
                HomeVM = new HomeViewModel();
                CurrentView = HomeVM;
            });

            OpenPdfMerge = new RelayCommand(o =>
            {
                PdfMergeVM = new PdfMergeViewModel();
                CurrentView = PdfMergeVM;
            });

            OpenPdfToWord = new RelayCommand(o =>
            {
                PdfToWordVM = new PdfToWordViewModel();
                CurrentView = PdfToWordVM;
            });


            ExitCmd = new RelayCommand(o =>
            {
                App.Current.Shutdown();
            });


        }
    }
}
