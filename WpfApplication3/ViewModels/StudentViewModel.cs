using System.ComponentModel;

namespace WpfApplication3.ViewModels
{
    public class StudentViewModel : IPersonViewModel
    {
        public string Name { get; set; }
        public bool IsOt4islen { get; set; }
        public int Cource { get; set; }
    }
}