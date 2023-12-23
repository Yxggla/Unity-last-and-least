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
    // Start is called before the first frame update
    public void CloseStartPanel()
    {
        camrera.SetActive(true);
        startPanel.SetActive(false);
        xueliangPanel.SetActive(true);
        Codeforcamera1.StartGame();
    }

    // 用于退出游戏的函数
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }
}
