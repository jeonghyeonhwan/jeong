using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]private GameObject Inven; // 인벤토리 패널
    [SerializeField]private GameObject UI1;
    [SerializeField]private GameObject UI2;
    [SerializeField]private GameObject UI3;
    void Update() {
        pushBtn();
    }

    void pushBtn(){
        if(Input.GetKeyDown(KeyCode.I)) {
            if(Inven.activeSelf) {
                hideInventory();
            }
            else {
                showInventory();
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            if(UI1.activeSelf) {
                hideUI1();
            }
            else {
                showUI1();
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            if(UI2.activeSelf) {
                hideUI2();
            }
            else {
                showUI2();
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)) {
            if(UI3.activeSelf) {
                hideUI3();
            }
            else {
                showUI3();
            }
        }
    }

    // 추후 추가 코드( ex : 소리) 추가를 위해 메서드
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

    void showUI2() {
        UI2.SetActive(true);
    }

    void hideUI2() {
        UI2.SetActive(false);
    }

    void showUI3() {
        UI3.SetActive(true);
    }

    void hideUI3() {
        UI3.SetActive(false);
    }

}
