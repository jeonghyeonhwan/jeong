using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject Inven; // 인벤토리 패널
    public GameObject UI1;
    public GameObject UI2;
    public GameObject UI3;

    void showInventory() {
        Inven.SetActive(true);
    }

    void hideInventory() {
        Inven.SetActive(false);
    }

    void showUI1() {
        UI1.SetActive(true);
    }

    void hideUI1() {
        UI1.SetActive(false);
    }


}
