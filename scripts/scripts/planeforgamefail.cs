using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class forgamefill : MonoBehaviour
{
    public GameObject gamefail;

   

    // Start is called before the first frame update
    public void GameOver()
    {
        // 关闭游戏失败的 GameObject
        gamefail.SetActive(false);
        // 重新加载当前场景
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }
}
