using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class formap : MonoBehaviour
{
    public Transform player; 
    // Start is called before the first frame update
    void Update()
    {
        // 设置小地图摄像机的位置，保持Y轴值不变
        Vector3 newPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
        transform.position = newPosition;
    }
}
