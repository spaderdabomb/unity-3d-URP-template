using System.Collections.Generic;
using UnityEngine;

public static class ItemRegistry
{
    private static readonly Dictionary<string, Item> _items = new Dictionary<string, Item>();
    public static Item GetItem(string uniqueID)
    {
        if (_items.Count <= 0)
        {
            var items = Resources.LoadAll<Item>("ScriptableObjects/Items");
            foreach (var item in items)
            {
                _items.Add(item.itemID, item);
            }
        }

        if (_items.TryGetValue(uniqueID, out Item itemData))
        {
            return itemData;
        }
        Debug.LogWarning($"Item not found: {uniqueID}");
        return null;
    }
}