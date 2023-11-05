using System;
using System.Collections;

namespace Week5Task4;
internal class CustomList<T> 
{
    T[] _array = new T[0];
    public int Count { get; private set; } = 0; 
    public int Capacity { get; set; } = 10;

    public CustomList()
    {
        
    }

    public CustomList(int capacity)
    {
        if (capacity <= 0) Capacity = 5;
        else Capacity = capacity;
    }

    public CustomList(int capacity, params T[] array) : this(capacity) 
    {
        _array = array;
        Count = array.Length;
    }

    public void Add(T item)
    {
        if (Count == _array.Length)
        {
            Array.Resize(ref _array, Count + Capacity);
        }
        _array[Count++] = item;
    }

    public void Clear() 
    {
        //yaza bilmedim
    }

    public bool Exist(T item)
    {
        foreach (T i in _array)
        {
            if (i.Equals(item))
            {
                return true;
            }
        }
        return false;
    }

    public void Remove(T item)
    {
        int index = Array.IndexOf(_array, item, 0, Count);
        if (index < 0 || index > Count - 1) return;
        T[] newArray = new T[Count - 1];
        for (int i = 0; i < index; i++)
        {
            newArray[i] = _array[i];
        }
        for (int i = index + 1; i < Count; i++)
        {
            newArray[i - 1] = _array[i];
        }
        _array = newArray;
        Count--;
    }

    public void Reverse()
    {
        for (int i = Count - 1; i >= 0; i--)
        {
            Console.WriteLine(_array[i]);
        }
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (_array[i].Equals(item))
            {
                return i;
            }
        }
        return -1;
    }

    public int LastIndexOf(T item)
    {
        for (int i = Count - 1 ; i >= 0; i--)
        {
            if (_array[i].Equals(item))
            {
                return i;
            }
        }
        return -1;
    }

    public void GetInfo()
    {
        foreach (var i in _array)
        {
            Console.WriteLine(i);
        }
    }
}
