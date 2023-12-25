using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class codeforstart1 : MonoBehaviour
{
    public GameObject nowPanel; // 开始面板
    
    public GameObject thenextPanel;
    
    // Start is called before the first frame update
    public void nextPanel()
    {
        thenextPanel.SetActive(true);
        nowPanel.SetActive(false);
    }
    
}
