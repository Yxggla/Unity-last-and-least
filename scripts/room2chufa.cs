using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room2chufa : MonoBehaviour
{
    public GameObject newpanel; // 面板对象的引用
    private bool hasTriggered = false; // 用于跟踪触发状态的变量
    public GameObject xiaoshuaipanel;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered ) // 确保是玩家触发了这个事件
        {
            newpanel.SetActive(true); // 激活面板
            xiaoshuaipanel.SetActive(true);
            hasTriggered = true;
        }
    }
}
