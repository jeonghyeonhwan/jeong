using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private List<Item> inventoryItems = new List<Item>();

    [SerializeField] private UIManager uiManager;
    
    // 아이템 획득
    public void AddItem(Item getItem)
    {
        inventoryItems.Add(getItem);
        // UI 갱신
        // uiManager.UpdateInventoryUI(inventoryItems);
    }

    // 아이템 제거
    public void RemoveItem(Item removeItem)
    {
        if (inventoryItems.Contains(removeItem))
        {
            inventoryItems.Remove(removeItem);
            // UI 갱신
            // uiManager.UpdateInventoryUI(inventoryItems);
        }
    }

    // 인벤토리에서 아이템 목록을 가져오기
    public List<Item> GetInventoryItems()
    {
        return inventoryItems;
    }
}