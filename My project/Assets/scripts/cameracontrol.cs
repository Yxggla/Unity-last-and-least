using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class cameracontrol : MonoBehaviour
{
    public Transform orientation;
    public Transform player;
    public Transform playerObj;
 
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }
 
    // Update is called once per frame
    void Update()
    {
        Vector3 Dir = player.position - new Vector3(transform.position.x, player.position.y, transform.position.z);
        orientation.forward = Dir.normalized;
        //获取按键
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 inputDir = orientation.forward * vertical + orientation.right * horizontal;
        if (inputDir != Vector3.zero)
        {
            playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
        }
    }
}