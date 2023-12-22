using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class codeforstart : MonoBehaviour
{
    public GameObject startPanel; // 开始面板
    // Start is called before the first frame update
    public void CloseStartPanel()
    {
        startPanel.SetActive(false);
    }

    // 用于退出游戏的函数
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }
}
