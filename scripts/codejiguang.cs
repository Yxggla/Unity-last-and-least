using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codejiguang : MonoBehaviour
{
    public GameObject laser;  // 指向激光（圆柱）的引用
    public GameObject gameoverPanel;  // 游戏结束面板

    void Start()
    {
        // 在2秒后，每3秒调用一次ToggleLaser方法
        InvokeRepeating("ToggleLaser", 2f, 3f);
    }

    void ToggleLaser()
    {
        // 切换激光状态
        laser.SetActive(!laser.activeSelf);
    }

    // 使用 OnTriggerStay 替代 OnTriggerEnter，确保持续检测碰撞
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))  // 确保是玩家碰撞到激光
        {
            gameoverPanel.SetActive(true);  // 激活游戏结束面板
        }
    }
}