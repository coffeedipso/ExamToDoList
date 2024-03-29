using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTodoList.Model
{
    public class ToDoTask
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public TimeSpan DueTime { get; set; }
        public Priority Priority { get; set; }
        public List<string> Tags { get; set; }
        public string Comment { get; set; }
        public string AttachedFile { get; set; }



    }


}
