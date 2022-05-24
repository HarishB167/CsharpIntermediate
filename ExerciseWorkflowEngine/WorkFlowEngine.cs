using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWorkflowEngine
{
    public class WorkFlowEngine
    {
        public void Run(IList<IActivity> workflow)
        {
            foreach (var activity in workflow)
            {
                activity.Execute();
            }
        }
    }
}
