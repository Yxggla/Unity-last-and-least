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
    public GameObject caidanPanel6;
    public GameObject xueliangPanel;
    public GameObject xiaoshuai1;
    public GameObject xiaoshuai2;
    public GameObject xiaoshuai3;
    public GameObject xiaoshuai4;
    public GameObject xiaoshuai5;
    public GameObject xiaoshuai6;
    public GameObject xiaoshuai7;
    public GameObject xiaoshuai8;
    public GameObject xiaoshuai9;
    public GameObject xiaoshuai10;
    public GameObject shitoupanel;
    public GameObject xiaoshuaipanel;
    public GameObject imgpaper1;
    public GameObject imgpaper2;
    public GameObject mimapanel;
    public GameObject playfabpanel;

    public GameObject imgpaper3;
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
        caidanPanel6.SetActive(false);
        xiaoshuai1.SetActive(false);
        xiaoshuai2.SetActive(false);
        xiaoshuai3.SetActive(false);
        xiaoshuai4.SetActive(false);
        xiaoshuai5.SetActive(false);
        xiaoshuai6.SetActive(false);
        xiaoshuai7.SetActive(false);
        xiaoshuai8.SetActive(false);
        xiaoshuai9.SetActive(false);
        xiaoshuai10.SetActive(false);
        xiaoshuaipanel.SetActive(false);
        shitoupanel.SetActive(false);
        imgpaper1.SetActive(false);
        imgpaper2.SetActive(false);
        imgpaper3.SetActive(false);
        mimapanel.SetActive(false);
        playfabpanel.SetActive(false);
    }

    // 在点击开始游戏按钮时调用此方法
    public void StartGame()
    {
        // 切换摄像机状态
        firstCamera.enabled = false;
        gameCamera.enabled = true;
    }
}
