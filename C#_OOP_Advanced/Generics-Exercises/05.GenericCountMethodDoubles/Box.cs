using System;
public class Box<T>:IComparable<Box<T>>
    where T : IComparable
{
    public T Value { get; set; }

    public Box(T value)
    {
        this.Value = value;
    }

    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {this.Value}";
    }

    public int CompareTo(Box<T> other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return Value.CompareTo(other.Value);
    }
}

