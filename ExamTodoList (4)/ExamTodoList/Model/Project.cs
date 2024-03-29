using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTodoList.Model
{
    internal class Project
    {
        public string Title { get; set; }
        public List<ToDoTask> Tasks { get; set; }
    }
}
