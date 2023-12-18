using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 5f;
    public float heightAbovePlayer = 2f; // 设置相机相对于玩家的高度
    public float offsetForward = -0.5f; // 设置相机相对于玩家前方的距离

    void Start()
    {
        player = GameObject.Find("Player").transform;
        if (player == null)
        {
            Debug.LogError("Player not found in the scene!");
        }

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // 获取鼠标输入
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // 根据鼠标输入旋转玩家和相机
        player.Rotate(Vector3.up * mouseX * rotationSpeed);
        transform.Rotate(Vector3.left * mouseY * rotationSpeed);

        // 限制相机的上下旋转
        float angle = transform.localEulerAngles.x;
        if (angle > 180f)
        {
            angle -= 360f;
        }
        angle = Mathf.Clamp(angle, -80f, 80f);
        transform.localEulerAngles = new Vector3(angle, 0f, 0f);

        // 更新相机位置
        transform.position = player.position + player.up * heightAbovePlayer - player.forward * offsetForward;
    }
}