using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube
{
    class Queue
    {
        public enum Format { MP4, MP3 };
        public enum Type { Download, Convert };
        public string Name { get; }
        public Type TaskType { get; }
        public string Source { get; }
        public string Destination { get; }
        public Format OutputFormat { get; }
        public string Quality { get; }


        /// <summary>
        /// Create new Queue with only task type, name, destination and source
        /// </summary>
        /// <param name="TaskType">Task type, can be Download or Convert</param>
        /// <param name="Name">Specific name for this task to display in queue list</param>
        /// <param name="Source">The data source for task. URL for download, path for convert</param>
        /// <param name="Destination">The destination for task. File path to save</param>
        public Queue(Type TaskType, string Name, string Source, string Destination)
        {
            this.TaskType = TaskType;
            this.Name = Name;
            this.Source = Source;
            this.Destination = Destination;
        }
        /// <summary>
        /// Create new Queue with task type, name, destination, source and specific output format
        /// </summary>
        /// <param name="TaskType">Task type, can be Download or Convert</param>
        /// <param name="Name">Specific name for this task to display in queue list</param>
        /// <param name="Source">The data source for task. URL for download, path for convert</param>
        /// <param name="Destination">The destination for task. File path to save</param>
        /// <param name="OutputFormat">Output format, can be MP3 or MP4</param>
        public Queue(Type TaskType, string Name, string Source, string Destination, Format OutputFormat)
        {
            this.TaskType = TaskType;
            this.Name = Name;
            this.Source = Source;
            this.Destination = Destination;
            this.OutputFormat = OutputFormat;
        }
        /// <summary>
        /// Create new Queue with task type, name, destination, source and specific output quality
        /// </summary>
        /// <param name="TaskType">Task type, can be Download or Convert</param>
        /// <param name="Name">Specific name for this task to display in queue list</param>
        /// <param name="Source">The data source for task. URL for download, path for convert</param>
        /// <param name="Destination">The destination for task. File path to save</param>
        /// <param name="Quality">The quality for output data. Resolution for mp4, bitrate for mp3</param>
        public Queue(Type TaskType, string Name, string Source, string Destination, string Quality)
        {
            this.TaskType = TaskType;
            this.Name = Name;
            this.Source = Source;
            this.Destination = Destination;
            this.Quality = Quality;
        }
        /// <summary>
        /// Create new Queue with task type, name, destination, source and specific output quality
        /// </summary>
        /// <param name="TaskType">Task type, can be Download or Convert</param>
        /// <param name="Name">Specific name for this task to display in queue list</param>
        /// <param name="Source">The data source for task. URL for download, path for convert</param>
        /// <param name="Destination">The destination for task. File path to save</param>
        /// <param name="Quality">The quality for output data. Resolution for mp4, bitrate for mp3</param>
        /// <param name="OutputFormat">Output format, can be MP3 or MP4</param>
        public Queue(Type TaskType, string Name, string Source, string Destination, Format OutputFormat, string Quality)
        {
            this.TaskType = TaskType;
            this.Name = Name;
            this.Source = Source;
            this.Destination = Destination;
            this.OutputFormat = OutputFormat;
            this.Quality = Quality;
        }

        public void Execute()
        {
            throw new NotImplementedException("WIP");
        }
    }
}
