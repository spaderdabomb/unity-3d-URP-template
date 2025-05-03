using Sirenix.OdinInspector;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Items/Item")]
public class Item : SerializedScriptableObject
{
    [Header("Details")]
    public string itemID = Guid.NewGuid().ToString();
    public string baseName;
    public string displayName;
    public string description;

    public int stackCount;
    public int maxStackCount = 50;
    public int baseSellValue = 1;

    [Header("Classification")]
    public ItemType itemType = ItemType.None;
    public ItemRarity itemRarity = ItemRarity.None;
    public ItemCategory itemCategories = ItemCategory.None;

    [Header("Assets")]
    public GameObject item3DPrefab;
    public Sprite itemSprite;

    public virtual void OnValidate()
    {
#if UNITY_EDITOR

#endif
    }

    public enum ItemRarity
    {
        None,
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Mythic
    }

    public enum ItemType
    {
        None = 0
    }

    [Flags]
    public enum ItemCategory
    {
        None = 0,
        Consumable = 2,
        Wieldable = 4,
        Wearable = 8,
    }
}