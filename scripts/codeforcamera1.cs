using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeforcamera1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera firstCamera; // 初始使用的摄像机
    public Camera gameCamera; // 游戏中使用的摄像机
    public GameObject startPanel1;
    public GameObject startPanel2;
    public GameObject startPanel3;
    public GameObject startPanel4;
    public GameObject startPanel5;

    public GameObject xueliangPanel;
    // Start is called before the first frame update
    void Start()
    {
        // 开始时启用初始摄像机，禁用游戏中摄像机
        firstCamera.enabled = true;
        gameCamera.enabled = false;
        startPanel1.SetActive(true);
        startPanel2.SetActive(false);
        startPanel3.SetActive(false);
        startPanel4.SetActive(false);
        startPanel5.SetActive(false);
        xueliangPanel.SetActive(false);
    }

    // 在点击开始游戏按钮时调用此方法
    public void StartGame()
    {
        // 切换摄像机状态
        firstCamera.enabled = false;
        gameCamera.enabled = true;
    }
}
