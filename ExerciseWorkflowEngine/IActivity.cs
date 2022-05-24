using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWorkflowEngine
{
    public class UploadVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video...");
        }
    }

    public class EncodingServiceActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video sent to encoding...");
        }
    }

    public class EmailNotifierActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video processing started...");
        }
    }

    public class VideoRecordManagerActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video status in database changed to Processing.");
        }
    }

    public interface IActivity
    {
        void Execute();
    }
}
