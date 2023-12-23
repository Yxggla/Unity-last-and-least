using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codejiguang : MonoBehaviour
{
    public GameObject laser;  // 指向激光（圆柱）的引用
    public GameObject gameoverPanel;  // 游戏结束面板
    private codeforhealthbar healthBarScript;
    private bool isTriggered = false; // 用于记录玩家是否已经触发过激光

    void Start()
    {
        // 在2秒后，每3秒调用一次ToggleLaser方法
        InvokeRepeating("ToggleLaser", 2f, 3f);
    }

    void ToggleLaser()
    {
        // 切换激光状态
        laser.SetActive(!laser.activeSelf);
        healthBarScript = FindObjectOfType<codeforhealthbar>(); //读取
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggered && healthBarScript != null)  // 确保是玩家碰撞到激光，并且之前没有触发过
        {
            Debug.Log("chufa");
            healthBarScript.TakeDamage();
            isTriggered = true;  // 标记为已触发
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = false;  // 一旦玩家离开激光区域，重置触发标记
        }
    }
}