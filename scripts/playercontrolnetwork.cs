using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerControlNetwork : NetworkBehaviour
{
    public float rotationSpeed = 110f;
    public float moveSpeed = 4f;
    public override void OnStartLocalPlayer()
    {
        Camera.main.transform.SetParent(transform);
        Camera.main.transform.localPosition = Vector3.zero;
    }
    void Update()
    {
        if (!isLocalPlayer)
            return;

        HandleRotationInput();
        HandleMovementInput();
    }
    void HandleRotationInput()
    {
        var moveX = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        transform.Rotate(0, moveX, 0);
        // 旋转逻辑
        CmdRotatePlayer(moveX);
    }

    void HandleMovementInput()
    {
        float moveX = 0f;
        float moveZ = 0f;
        // 前进和后退移动
        if (Input.GetKey(KeyCode.W))
        {
            moveZ = moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveZ = -moveSpeed * Time.deltaTime;
        }
        // 移动逻辑
        CmdMovePlayer(moveX, moveZ);
    }
    
    [Command]
    void CmdMovePlayer(float moveX, float moveZ)
    {
        RpcMovePlayer(moveX, moveZ);
    }
    [ClientRpc]
    void RpcMovePlayer(float moveX, float moveZ)
    {
        // 在所有客户端上同步移动
        transform.Translate(moveX, 0, moveZ);
    }
    [Command]
    void CmdRotatePlayer(float rotationAmount)
    {
        RpcRotatePlayer(rotationAmount);
    }
    [ClientRpc]
    void RpcRotatePlayer(float rotationAmount)
    {
        // 在所有客户端上同步旋转
        transform.Rotate(0, rotationAmount, 0);
    }


}