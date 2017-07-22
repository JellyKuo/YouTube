using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace YouTube
{
    public static class Process
    {
        public static ObservableCollection<Task> Queue;
        public static void StartExecuteQueue()
        {
            if (Queue.Count <= 0)
                throw new InvalidOperationException("Sequence Queue is empty!");
            while (Queue.Count > 0)
            {
                Queue[0].ExecuteTask();
                Queue.RemoveAt(0);
            }
        }
    }
    public class Task
    {
        public enum Type { Download, Convert };
        public enum Format { MP4, MP3 };
        public Type TaskType { get; }
        public string Name { get; }
        public string Source { get; }
        public string Destination { get; }
        public Format OutputFormat { get; }
        public string Quality { get; }

        public Task(Type TaskType,string Name,string Source, string Destination,Format OutputFormat, string Quality)
        {
            this.TaskType = TaskType;
            this.Name = Name;
            this.Source = Source;
            this.Destination = Destination;
            this.OutputFormat = OutputFormat;
            this.Quality = Quality;
        }

        public void ExecuteTask()
        {

        }
    }
}
