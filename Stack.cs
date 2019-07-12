using System.Collections;
using System.Collections.Generic;

namespace InheritanceExercise1
{
    public class Stack
    {
        private ArrayList list = new ArrayList();

        public void Push(object obj)
        {
            if(obj != null)
            {
                list.Insert(0, obj);
            }
            else
            {
                throw new System.InvalidOperationException("Cannot be null");
            }
        }

        public object Pop()
        {
            if(list.Count != 0)
            {
                object temp = list[0];
                list.RemoveAt(0);
                return temp;
            }
            else
            {
                throw new System.InvalidOperationException("The list is empty");
            }
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
