public class ObjectPool<T> where T: new()
{
    private List<T> objectList = new List<T>();
    private int counter = 0;
    private int maxObjects = 5;

    public int getCounter() => counter;

    public T getObj()
    {
        T ObjectItem;

        if (counter <= 0)
            return new T();
    
        ObjectItem = objectList[0];
        objectList.RemoveAt(0);
        counter--;

        return ObjectItem;
    }

    public void releaseObj(T item)
    {
        if (counter < maxObjects)
        {
            objectList.Add(item);
            counter++;
        }
        else
            Console.WriteLine("Too many objects in the pool!");
    }
}