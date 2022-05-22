using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class ExerciseInheritance
    {
        public void run()
        {
            Console.WriteLine("Exercise Inheritance.\n");

            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }

    public class Stack
    {
        private readonly List<object> stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("null value cannot be stored in stack.");
            else
                stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove from empty stack.");
            }
            else
            {
                var obj = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return obj;
            }
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}
