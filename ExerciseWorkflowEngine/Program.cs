using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkFlowEngine();

            var workflow = new List<IActivity>();
            workflow.Add(new UploadVideoActivity());
            workflow.Add(new EncodingServiceActivity());
            workflow.Add(new EmailNotifierActivity());
            workflow.Add(new VideoRecordManagerActivity());

            workflowEngine.Run(workflow);
        }
    }
}
