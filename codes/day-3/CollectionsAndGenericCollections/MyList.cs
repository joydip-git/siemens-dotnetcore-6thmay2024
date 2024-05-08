namespace CollectionsAndGenericCollections
{
    class MyList<T>
    {
        T[] elements;
        static int index = 0;
        public MyList()
        {
            elements = new T[4];
        }
        public void Add(T obj)
        {
            if (index == elements.Length)
            {
                T[] copy = new T[elements.Length];
                elements.CopyTo(copy, 0);
                elements = new T[copy.Length * 2];
                copy.CopyTo(elements, 0);
            }
            elements[index] = obj;
            index++;
        }
        public void Insert(int i, T element)
        {
            if (i > index)
                throw new Exception();
        }
        public int Count => index;
        public int Capacity => elements.Length;
    }
}
