using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;  // 아이템 이름
    public Sprite itemIcon;  // 아이템 아이콘 이미지
    public int itemCount;    // 아이템 개수
    public string itemDescription;  // 아이템 설명

    // 생성자 (필요한 경우 사용)
    public void InitializeItem(string _itemName, string _itemDes, int _itemCount)
    {
        itemName = _itemName;
        itemDescription = _itemDes;
        itemCount = _itemCount;
    }
}
