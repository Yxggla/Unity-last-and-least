using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class codeforstart2 : MonoBehaviour
{
    public GameObject nowPanel; // 开始面板
    public codeforcamera1 Codeforcamera1;
    public GameObject xueliangPanel;
    public GameObject nextPanel;
    public GameObject camrera;
    public GameObject xiaoshuai1;
    public GameObject xiaoshuaipanel;

    
    // Start is called before the first frame update
    public void kaishiPanel()
    {
        nowPanel.SetActive(false);
        camrera.SetActive(true);
       // xueliangPanel.SetActive(true);
        Codeforcamera1.StartGame();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        xiaoshuaipanel.SetActive(true);
        xiaoshuai1.SetActive(true);
        
    }

    public void wanfaPanel()
    {
        nowPanel.SetActive(false);
        nextPanel.SetActive(true);
    }
    
}