using System.Collections.ObjectModel;
using WpfApp1.DB;
using WpfApp1.Model;
using WpfApp1.Tools;
using WpfApp1.View;

namespace WpfApp1.ViewModel
{
    public class GroupManagmentViewModel
    {
        public ObservableCollection<Group> Groups { get; set; } = new();
        public Group SelectedGroup { get; set; }

        public MvvmCommand OpenCreateStudentPage { get; set; }

        public GroupManagmentViewModel()
        {
            Groups = new ObservableCollection<Group>(GroupDB.Groups);
            OpenCreateStudentPage = new MvvmCommand(() => {
                MainViewModel.ChangePage(new StudentCreatePage(new StudentCreateViewModel(SelectedGroup)));            
            });
        }
    }
}
