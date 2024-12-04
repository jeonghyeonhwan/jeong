using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]private GameObject _inventory; // 인벤토리 패널
    [SerializeField]private GameObject UI1;
    [SerializeField]private GameObject UI2;
    [SerializeField]private GameObject UI3;
    [SerializeField]private GameObject UI4;
    [SerializeField]private GameObject _chat;

    // 채팅 버튼
    [SerializeField] private Button[] buttons;

    ChattingManager chat;


    void Update() {
        pushButton();

        if (Input.GetKeyDown(KeyCode.Tab) && _chat.activeSelf)
        {
            chat.NextLine(); // 다음문장을호
        }
    }

    void pushButton(){
        if(Input.GetKeyDown(KeyCode.I)) {
            if(_inventory.activeSelf) {
                Hideinventory();
            }
            else {
                Showinventory();
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            if(UI1.activeSelf) {
                HideUI1();
            }
            else {
                ShowUI1();
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            if(UI2.activeSelf) {
                HideUI2();
            }
            else {
                ShowUI2();
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha3)) {
            if(UI3.activeSelf) {
                HideUI3();
            }
            else {
                ShowUI3();
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha4)) {
            if(UI4.activeSelf) {
                HideUI4();
            }
            else {
                ShowUI4();
            }
        }
    }







    void ShowChat(Button button) {
        if(button == buttons[0]) {
            chat.DisplayChat("NPC_1");
        }
        if(button == buttons[1]) {
            chat.DisplayChat("NPC_2");
        }
    }

    void HideChat() {
        _chat.SetActive(false);
    }

    // 추후 추가 코드( ex : 소리) 추가를 위해 메서드
    void ShowInventory() {
        _inventory.SetActive(true);
    }

    void HideInventory() {
        _inventory.SetActive(false);
    }

    void ShowUI1() {
        UI1.SetActive(true);
    }

    void HideUI1() {
        UI1.SetActive(false);
    }

    void ShowUI2() {
        UI2.SetActive(true);
    }

    void HideUI2() {
        UI2.SetActive(false);
    }

    void ShowUI3() {
        UI3.SetActive(true);
    }

    void HideUI3() {
        UI3.SetActive(false);
    }

    void ShowUI4() {
        UI4.SetActive(true);
    }

    void HideUI4() {
        UI4.SetActive(false);
    }

}
