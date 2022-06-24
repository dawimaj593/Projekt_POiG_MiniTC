using MiniTC.ViewModel.BaseClass;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MiniTC.Annotations;

namespace MiniTC.ViewModel
{
    using Model;
    class ViewModel : INotifyPropertyChanged
    {
        Model _model = new Model();
        

        private string leftdirectory = null;
        public string Left
        {
            get { return leftdirectory; }
            set
            {
                leftdirectory = value;
                OnPropertyChanged(nameof(CurrentLeftFiles));
                OnPropertyChanged(nameof(Left));
            }
        }
        public ObservableCollection<string> CurrentLeftFiles
        {
            get{ return new ObservableCollection<string> (_model.GetAllFiles(Left));}
        }
        private ICommand leftchange = null;
        public ICommand LeftChceck
        {
            get
            {
                if (leftchange == null)
                    leftchange = new RelayCommand(
                        x => {Left = _model.ChangePath(Left, SelectedFile); },
                        x => true);
                return leftchange;
            }
        }
        

        private string rightdirectory = null;
        public string Right
        {
            get { return rightdirectory; }
            set
            {
                rightdirectory = value;
                OnPropertyChanged(nameof(CurrentRightFiles));
                OnPropertyChanged(nameof(Right));
            }
        }
        public ObservableCollection<string> CurrentRightFiles
        {
            get{ return new ObservableCollection<string> (_model.GetAllFiles(Right)); }
        }
        private ICommand rightcheck = null;
        public ICommand RightCheck
        {
            get
            {
                if (rightcheck == null)
                    rightcheck = new RelayCommand(
                    (arg) => { Right = _model.ChangePath(Right, SelectedFile);},
                    (arg) => true );
                return rightcheck;
            }

        }
        

        public ObservableCollection<string> CurrentDrives
        {
            get{ return new ObservableCollection<string>(_model.GetAllDrives()); }
        }
        public string SelectedFile { get; set; }
        
        private ICommand _copy = null;
        public ICommand Copy
        {
            get
            {
                if (_copy == null)
                {
                    _copy = new RelayCommand(x =>
                    {
                        if (Right != null)
                        {
                            string source = Left + @"\" + SelectedFile;
                            string dest = rightdirectory + @"\" + SelectedFile;
                            _model.CopyFile(source, dest);
                        }
                        OnPropertyChanged(nameof(CurrentRightFiles));
                    },
                    x => true);
                }
                return _copy;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
