using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeforgamewin : MonoBehaviour
{
    public GameObject gamewin;
    // Start is called before the first frame update
    public void Gamewin()
    {
        // 关闭游戏失败的 GameObject
        gamewin.SetActive(false);
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
       
    }
}
