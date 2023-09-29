namespace DataStructuresAndAlgorithms.DataStructures.Arrays;


//<summary>
// Design a Dynamic Array (aka a resizable array) class, such as an ArrayList in Java or a vector in C++.
// 
// Your DynamicArray class should support the following operations:
// 
// DynamicArray(int capacity) will initialize an empty array with a capacity of capacity, where capacity > 0.
// int get(int i) will return the element at index i. Assume that index i is valid.
// void insert(int i, int n) will insert the element n at index i. Assume that index i is valid.
// void pushback(int n) will push the element n to the end of the array.
// int popback() will pop and return the element at the end of the array. Assume that the array is non-empty.
// void resize() will double the capacity of the array.
// int getSize() will return the number of elements in the array.
// int getCapacity() will return the capacity of the array.
// If we call void pushback(int n) but the array is full, we should resize the array first. 
//</summary>
public class DynamicArrayImplementation
{
    private int[] _array;
    private int _size;
    private int _capacity;

    public DynamicArrayImplementation(int capacity)
    {
        _array = new int[capacity];
        _size = 0;
        _capacity = capacity;
    }
    
    public int Get(int index)
    {
        return _array[index];
    }

    public void Insert(int i, int n)
    {
        if (_size == _capacity)
        {
            Resize();
        }

        for (var j = _size; j > i; j--)
        {
            _array[j] = _array[j - 1];
        }

        _array[i] = n;
        _size++;
    }
    
    // push the element to the end of the array
    public void Pushback(int n)
    {
        if (_size == _array.Length)
        {
            Resize();
        }

        _array[_size] = n;
        _size++;
    }

    // pop the element from the end of the array
    public int Popback()
    {
        if (_size > 0)
        {
            _size--;
        }
        return _array[_size];
    }
    
    // resize the array (double the capacity)
    private void Resize()
    {
        _capacity *= 2;
        var newArray = new int[_capacity];
        for (var i = 0; i < _size; i++)
        {
            newArray[i] = _array[i];
        }
        _array = newArray;
    }
    
    public int GetSize()
    {
        return _size;
    }
    
    public int GetCapacity()
    {
        return _capacity;
    }
}