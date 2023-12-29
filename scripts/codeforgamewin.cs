using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeforgamewin : MonoBehaviour
{
    public GameObject gamewinplane;  //游戏成功的面板
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") // 检查标签是否为"Player"
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            gamewinplane.SetActive(true); // 激活指定的游戏对象
        }
    }
}
