using UnityEngine;
[System.Serializable]
public class Item
{
    public string itemName;  // 아이템 이름
    public Sprite itemIcon;  // 아이템 아이콘 이미지
    public int itemCount; // 아이템 개수
    public string itemDesc; // 아이템 설명

    public Item(string name, Sprite icon, int count, string desc) {
        itemName = name;
        itemIcon = icon;
        itemCount = count;
        itemDesc = desc;
    }
}
