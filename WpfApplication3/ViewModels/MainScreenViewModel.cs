using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using WpfApplication3.Annotations;
using WpfApplication3.Model;

namespace WpfApplication3.ViewModels
{
    public class MainScreenViewModel : INotifyPropertyChanged
    {
        private object _currentPerson;

        public MainScreenViewModel()
        {
            var peopleService = new PeopleService();
            Persons = new ObservableCollection<IPersonViewModel>(
                peopleService
                    .GetStudents()
                    .Select(it => new StudentViewModel
                    {
                        Name = it.Name,
                        Cource = it.Cource,
                        IsOt4islen = it.IsOt4islen
                    }).OfType<IPersonViewModel>()
                    .Union(
                        peopleService
                            .GetWorkers()
                            .Select(it => new WorkerViewModel
                            {
                                Name = it.Name,
                                Status = it.Status
                            })));
            Click = new DelegateCommand<IPersonViewModel>(it => { CurrentPerson = it; });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand Click { get; set; }

        public object CurrentPerson
        {
            get { return _currentPerson; }
            set
            {
                _currentPerson = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<IPersonViewModel> Persons { get; set; }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if(handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}