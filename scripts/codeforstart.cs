using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class codeforstart : MonoBehaviour
{
    public GameObject startPanel; // 开始面板

    public codeforcamera1 Codeforcamera1;
    public GameObject xueliangPanel;
    
    public GameObject camrera;
    public GameObject start2Panel;
   

    public void CloseStartPanel()
    {
        // camrera.SetActive(true);
        // xueliangPanel.SetActive(true);
        // Codeforcamera1.StartGame();
        startPanel.SetActive(false);
        start2Panel.SetActive(true);
    }

    // 用于退出游戏的函数
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }
}
