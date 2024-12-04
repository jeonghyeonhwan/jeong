using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChattingManager : MonoBehaviour
{
    // Text 컴포넌트를 할당할 변수
    public Text chatText;

    // 각 NPC별 대화 내용 배열
    public string[] NPC_1 = {
        "안녕",
        "하세요"
    };
    public string[] NPC_2 = {
        "안녕2",
        "하세요2"
    };

    // 각 NPC별 대화 인덱스
    private int currentIndexNPC1 = 0;
    private int currentIndexNPC2 = 0;

    // 대화 표시
    public void DisplayChat(string npcName)
    {
        if (npcName == "NPC_1" && currentIndexNPC1 < NPC_1.Length)
        {
            chatText.text = NPC_1[currentIndexNPC1];
        }
        else if (npcName == "NPC_2" && currentIndexNPC2 < NPC_2.Length)
        {
            chatText.text = NPC_2[currentIndexNPC2];
        }
    }

    // 탭 키를 눌러서 다음 대화로 진행
    public void NextLine(string npcName)
    {
        if (npcName == "NPC_1")
        {
            if (currentIndexNPC1 < NPC_1.Length - 1)
            {
                currentIndexNPC1++;
                DisplayChat(npcName);
            }
            else
            {
                chatText.text = "끝";
            }
        }
        else if (npcName == "NPC_2")
        {
            if (currentIndexNPC2 < NPC_2.Length - 1)
            {
                currentIndexNPC2++;
                DisplayChat(npcName);
            }
            else
            {
                chatText.text = "끝";
            }
        }
    }
}
