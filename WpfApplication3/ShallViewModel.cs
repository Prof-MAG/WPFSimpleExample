using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApplication3.Annotations;
using WpfApplication3.ViewModels;

namespace WpfApplication3
{
    public class ShellViewModel : INotifyPropertyChanged
    {
        private object _content;

        public ShellViewModel()
        {
            Content = new MainScreenViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Content
        {
            get { return _content; }
            set
            {
                if(Equals(value, _content)) return;
                _content = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if(handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}