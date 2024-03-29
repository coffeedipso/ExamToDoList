using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using ExamTodoList.Model;
using ExamToDoList.Model.CalibrCameraApp.Commands;
using Microsoft.VisualBasic;

namespace ExamTodoList.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {



        private Task selectedTask;
        public Task SelectedTask
        {
            get { return selectedTask; }
            set
            {
                selectedTask = value;
                OnPropertyChanged(nameof(SelectedTask));
            }
        }

        private ObservableCollection<ToDoTask> tasks;
        public ObservableCollection<ToDoTask> Tasks
        {
            get { return tasks; }
            set
            {
                tasks = value;
                OnPropertyChanged(nameof(Tasks));
            }
        }

        private ObservableCollection<string> priorityCategories = new ObservableCollection<string>
        {
            "High",
            "Medium",
            "Low"
        };


        public ObservableCollection<string> PriorityCategories
        {
            get { return priorityCategories; }
            set
            {
                priorityCategories = value;
                OnPropertyChanged(nameof(PriorityCategories));
            }
        }

        private string selectedPriorityCategory;
        public string SelectedPriorityCategory
        {
            get { return selectedPriorityCategory; }
            set
            {
                selectedPriorityCategory = value;
                OnPropertyChanged(nameof(SelectedPriorityCategory));
            }
        }

        public RelayCommand AddTaskCommand { get; private set; }
        public RelayCommand FileWriter { get; private set; }
        public RelayCommand FileReader { get; private set; }

        public MainViewModel()
        {
            Tasks = new ObservableCollection<ToDoTask>();

            AddTaskCommand = new RelayCommand(obj =>
            {
                SaveTask();
                MessageBox.Show("Сохранение задачи");
            }, obj => CanAddTask());


            FileWriter = new RelayCommand(obj =>
            {
                FileTasks.FileTaskWrite(tasks);
                MessageBox.Show("Запись");
            }, obj => true);


            FileReader = new RelayCommand(obj =>
            {
                Tasks = FileTasks.FileTaskRead();
                MessageBox.Show("Чтение");
            }, obj => true);
        }

        private bool CanAddTask()
        {
            return !string.IsNullOrEmpty(selectedPriorityCategory);
        }


        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private DateTime _dueDate;
        public DateTime DueDate
        {
            get { return _dueDate; }
            set
            {
                _dueDate = value;
                OnPropertyChanged(nameof(DueDate));
            }
        }

        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }


        private void SaveTask()
        {
            // Создание новой задачи
            ToDoTask newTask = new ToDoTask
            {
                Title = Title,
                DueDate = DueDate,
               Priority = (Priority)Enum.Parse(typeof(Priority), selectedPriorityCategory),
               Comment= Comment
               
                // Заполните остальные свойства задачи соответствующими значениями
                // ...
            };

            // Добавление задачи в коллекцию
            Tasks.Add(newTask);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}