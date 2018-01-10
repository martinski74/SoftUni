using System;

public class ArrayList<T>
{
    private const int Initial_Capacity = 2;
    private T[] arr;

    public ArrayList()
    {
        this.arr = new T[Initial_Capacity];
    }
    public int Count { get; private set; }

    public T this[int index]
    {
        get
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return this.arr[index];
        }

        set
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.arr[index] = value;
        }
    }

    public void Add(T item)
    {
        if (this.Count == this.arr.Length)
        {
            this.Resize();
        }
        this.arr[this.Count++] = item;
    }

    private void Resize()
    {
        T[] copy = new T[this.arr.Length * 2];
        for (int i = 0; i < this.arr.Length; i++)
        {
            copy[i] = this.arr[i];
        }
        this.arr = copy;
    }

    public T RemoveAt(int index)
    {
        if (index >= this.Count)
        {
            throw new ArgumentOutOfRangeException();
        }
        T element = this.arr[index];
        this.arr[index] = default(T);
        this.Shift(index);
        this.Count--;

        if (this.Count <= this.arr.Length / 4)
        {
            this.Shrink();
        }
        return element;
    }

    private void Shrink()
    {
        T[] copy = new T[this.arr.Length / 2];
        for (int i = 0; i < this.Count; i++)
        {
            copy[i] = this.arr[i];
        }
        this.arr = copy;
    }

    private void Shift(int index)
    {
        for (int i = index; i < this.Count; i++)
        {
            this.arr[i] = this.arr[i + 1];
        }
    }
}
