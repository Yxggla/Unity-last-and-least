using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class codeforstart : MonoBehaviour
{
    public GameObject nowPanel; // 开始面板
    
    public GameObject thenextPanel;
    
    // Start is called before the first frame update
    public void nextPanel()
    {
        thenextPanel.SetActive(true);
        nowPanel.SetActive(false);
    }

    // 用于退出游戏的函数
    public void ExitGame()
    {
        // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
