using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> data;

        public ListyIterator(params T[] elements)
        {
            this.data = new List<T>(elements);
            this.CurrentIndex = 0;
        }
        public int CurrentIndex { get; set; }

        public ListyIterator(List<T> collection)
        {
            this.data = collection;
        }

        public bool Move()
        {
            if (this.data.Count - 1 > CurrentIndex)
            {
                this.CurrentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.data.Count - 1 > CurrentIndex)
            {
                return true;
            }

            return false;
        }

        public T Print()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return this.data[CurrentIndex];
        }

        public string PrintAll()
        {
            if (this.data.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            var sb = new StringBuilder();
            foreach (var element in this.data)
            {
                sb.Append($"{element} ");
            }
            return sb.ToString().Trim();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}