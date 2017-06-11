using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab2.Queue
{
    class MStack : IEnumerable<int>
    {
        private struct StackNode
        {
            public int Value;
            public int Min, Max;

            public StackNode(int value, int min, int max)
            {
                Value = value;
                Min = min;
                Max = max;
            }
        }

        public MStack() { }

        public MStack(MStack stack)
        {
            foreach (int item in stack)
            {
                Push(item);
            }
        }

        public void Push(int item)
        {
            stack.Push(Empty ?
                new StackNode(item, item, item) :
                new StackNode(item, Math.Min(item, Min), Math.Max(item, Max)));
        }

        public void Push(params int[] items)
        {
            foreach (int item in items)
            {
                Push(item);
            }
        }

        public int Pop()
        {
            return stack.Pop().Value;
        }

        public int Peek()
        {
            return stack.Peek().Value;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in stack)
            {
                yield return item.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count { get { return stack.Count; } }
        public bool Empty { get { return Count == 0; } }

        public int Min { get { return stack.Peek().Min; } }
        public int Max { get { return stack.Peek().Max; } }

        private Stack<StackNode> stack = new Stack<StackNode>();
    }
}
