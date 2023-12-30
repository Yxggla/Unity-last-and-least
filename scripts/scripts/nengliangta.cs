using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nengliangta : MonoBehaviour
{
    
    public Transform player; // 玩家的 Transform 组件
    public codeforshitoushouji shitoucode;
    public GameObject shitoupanel;
    public GameObject xiaoshuaipanel;
    public GameObject nextpanel;
    void Update()
    {
        // 检查玩家是否按下了 "E" 键
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(shitoucode.full);
            // 检查玩家与能量塔之间的距离是否小于 3f
            float distance = Vector3.Distance(transform.position, player.position);
            if (distance < 5f && shitoucode.full)
            {
                shitoupanel.SetActive(false);
                xiaoshuaipanel.SetActive(true);
                nextpanel.SetActive(true);
            }
        }
    }
}
