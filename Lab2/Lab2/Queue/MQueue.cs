using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab2.Queue
{
    public class MQueue : IEnumerable<int>
    {
        private MStack inStack = new MStack();
        private MStack outStack = new MStack();

        public void Enqueue(int item)
        {
            inStack.Push(item);
        }

        public void Enqueue(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Enqueue(items[i]);
            }
        }

        public int Dequeue()
        {
            if (outStack.Empty)
            {
                while (!inStack.Empty)
                {
                    outStack.Push(inStack.Pop());
                }
            }
            return outStack.Pop();
        }

        public int Min()
        {
            if (Empty)
            {
                throw new Exception();
            }
            else if (inStack.Empty && !outStack.Empty)
            {
                return outStack.Min;
            }
            else if (!inStack.Empty && outStack.Empty)
            {
                return inStack.Min;
            }
            else
            {
                return Math.Min(inStack.Min, outStack.Min);
            }
        }

        public int Max()
        {
            if (Empty)
            {
                throw new Exception();
            }
            else if (inStack.Empty && !outStack.Empty)
            {
                return outStack.Max;
            }
            else if (!inStack.Empty && outStack.Empty)
            {
                return inStack.Max;
            }
            else
            {
                return Math.Max(inStack.Max, outStack.Max);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in outStack)
            {
                yield return item;
            }
            foreach (var item in new MStack(inStack))
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count { get { return inStack.Count + outStack.Count; } }
        public bool Empty { get { return Count == 0; } }
    }
}
