using ConsoleApp5;

public class SuperHashTable<T>
{
    private Item<T>[] items;
    private Dictionary<string, Item<T>> lookupTable;

    public SuperHashTable(int size)
    {
        items = new Item<T>[size];

        lookupTable = new Dictionary<string, Item<T>>();

        for (int i = 0; i < items.Length; i++)
        {
            items[i] = new Item<T>(i);
        }
    }

    public void Add(T item)
    {
        var key = GetHash(item.ToString());

        if (items[key] == null)
        {
            items[key] = new Item<T>(key);
        }

        items[key].Nodes.Add(item);
        lookupTable[item.ToString()] = items[key];
    }

    public bool Search(string name)
    {
        if (lookupTable.ContainsKey(name))
        {
            var item = lookupTable[name];

            foreach (var node in item.Nodes)
            {
                if (node is Person person && person.Name == name)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private int GetHash(string item)
    {
        return Math.Abs(item.GetHashCode()) % items.Length;
    }
}