using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVVM_Demo.Model;

namespace MVVM_Demo.ViewModel
{
    public class StudentViewModel : BindableBase
    {
        public MyICommand DeleteCommand { get; set; }
        public MyCommand<IList> SelectionChangedCommand { get; set; }
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        private Student _selectedStudent;
        public Student SelectedStudent
        {
            get => _selectedStudent;
            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        private Student selectedItems;
        public Student SelectedItems
        {
            get => selectedItems;
            set
            {
                selectedItems = value;
                OnPropertyChanged(nameof(SelectedItems));
            }
        }
        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            SelectionChangedCommand = new MyCommand<IList>(SelectionChanged);
        }

        private void SelectionChanged(IList item)
        {
            var selected = item;
        }
        private bool CanDelete() => SelectedStudent != null;
        private void OnDelete() => Students.Remove(SelectedStudent);

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });
            students.Add(new Student { FirstName = "Mihaly", LastName = "Schmidt" });
            students.Add(new Student { FirstName = "Mária", LastName = "Schmidt" });


            Students = students;
        }
    }
}
