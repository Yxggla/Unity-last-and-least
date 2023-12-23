using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeforcamera1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera firstCamera; // 初始使用的摄像机
    public Camera gameCamera; // 游戏中使用的摄像机

    void Start()
    {
        // 开始时启用初始摄像机，禁用游戏中摄像机
        firstCamera.enabled = true;
        gameCamera.enabled = false;
    }

    // 在点击开始游戏按钮时调用此方法
    public void StartGame()
    {
        // 切换摄像机状态
        firstCamera.enabled = false;
        gameCamera.enabled = true;
    }
}
