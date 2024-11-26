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
            if(Inven.activeSelf) { // Inven 활성화 돼있다면
                Inven.SetActive(false);
            }
            else {
                Inven.SetActive(true);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            if(UI1.activeSelf) {
                UI1.SetActive(false);
            }
            else {
                UI1.SetActive(true);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            if(UI2.activeSelf) {
                UI2.SetActive(false);
            }
            else {
                UI2.SetActive(true);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)) {
            if(UI3.activeSelf) {
                UI3.SetActive(false);
            }
            else {
                UI3.SetActive(true);
            }
        }
    }
}
