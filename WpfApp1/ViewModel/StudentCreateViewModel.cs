using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.Tools;
using WpfApp1.View;

namespace WpfApp1.ViewModel
{
    public class StudentCreateViewModel
    {
        public Student Student { get; set; }
        private Group? selectedGroup;

        public MvvmCommand AddStudent { get; set; }

        public StudentCreateViewModel(Group? selectedGroup)
        {
            Student = new();
            this.selectedGroup = selectedGroup;

            AddStudent = new MvvmCommand(() => {
                selectedGroup.Students.Add(Student);
                MainViewModel.ChangePage(new GroupManagmentPage());
            });
        }
    }
}
