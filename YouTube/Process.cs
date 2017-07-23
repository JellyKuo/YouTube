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
        private static ObservableCollection<Work> Queue = new ObservableCollection<Work>();
        #region EventHandler & Events
        public delegate void EnqueueHandler(Work w);
        public delegate void DequeueHandler(int ID);
        public delegate void QueueMoveHandler(int OldID, int NewID);
        public static event EnqueueHandler OnEnqueue;
        public static event DequeueHandler OnDequeue;
        public static event QueueMoveHandler OnQueueMove;
        #endregion
        #region EventArgs
        //public class EnqueueArgs : EventArgs
        //{
        //    private Work w;
        //    public EnqueueArgs(Work w)
        //    {
        //        this.w = w;
        //    }

        //    public Work Work
        //    {
        //        get
        //        {
        //            return w;
        //        }
        //    }
        //}
        //public class DequeueArgs : EventArgs
        //{
        //    private int id;
        //    public DequeueArgs(int id)
        //    {
        //        this.id = id;
        //    }

        //    public int ID
        //    {
        //        get
        //        {
        //            return id;
        //        }
        //    }
        //}
        #endregion

        public static void Enqueue(Work w)
        {
            if (w == null)
                return;
            OnEnqueue(w);
        }

        public static void Dequeue(int ID)
        {
            if (ID > Queue.Count)
                throw new IndexOutOfRangeException("Removing object id is bigger than queue count");
            OnDequeue(ID);
            Queue.RemoveAt(ID);
        }

        public static void MoveUp(int ID, int Amount)
        {
            if (ID - Amount < 0)
                throw new IndexOutOfRangeException("Moving object out of the index");
            Queue.Move(ID, ID - Amount);
            OnQueueMove(ID, ID - Amount);
        }

        public static void MoveDown(int ID, int Amount)
        {
            if (ID + Amount > Queue.Count)
                throw new IndexOutOfRangeException("Moving object out of the index");
            Queue.Move(ID, ID + Amount);
            OnQueueMove(ID, ID + Amount);
        }

        public static void StartExecuteQueue()
        {
            if (Queue.Count <= 0)
                throw new InvalidOperationException("Sequence Queue is empty!");
            for(int i = 0;i < Queue.Count; i++)
            {
                Queue[i].TaskState = Work.State.Processing;
                Queue[i].ExecuteWorkAsync();
                Queue[i].TaskState = Work.State.Completed;
            }
        }
    }

    public class Work
    {
        public enum Type { Download, Convert };
        public enum Format { MP4, MP3 };
        public enum State { Pending, Processing, Completed,Error }
        public Type TaskType { get; }
        public State TaskState { get; set; }
        public string Name { get; }
        public string Source { get; }
        public string Destination { get; }
        public Format OutputFormat { get; }
        public string Quality { get; }

        public Work(Type TaskType, string Name, string Source, string Destination, Format OutputFormat, string Quality)
        {
            this.TaskType = TaskType;
            this.Name = Name;
            this.Source = Source;
            this.Destination = Destination;
            this.OutputFormat = OutputFormat;
            this.Quality = Quality;
            this.TaskState = State.Pending;
        }

        public void ExecuteWorkAsync()
        {
            throw new NotImplementedException("WIP");
        }
    }
}
