using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject doorLock; // 门锁对象
    public GameObject passwordPanel; // 密码面板
    public GameObject player; // 人物
    public Camera playerCamera; // 玩家摄像机
    public float maxDistance = 5.0f; // 最大交互距离
    public string password;
    public Buttoninput buttonInput;//引用Buttoninput的代码，传密码
    public GameObject changedoor;
    public GameObject thisdoorlight;
    public GameObject thisdoorlight2;

    // Start is called before the first frame update
    void Start()
    {
        // 初始化时隐藏密码面板
        passwordPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update() {
        // 当玩家靠近门锁并按下E键时
        if (IsPlayerCloseEnough() && Input.GetKeyDown(KeyCode.E)) {
            buttonInput.rightpassword = password;
            buttonInput.thistdoorlight = thisdoorlight;
            buttonInput.thistdoorlight2 = thisdoorlight2;
            DoorCont doorComponent = changedoor.GetComponent<DoorCont>();
            buttonInput.door = doorComponent;
            passwordPanel.SetActive(true); // 显示密码面板
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    bool IsPlayerCloseEnough() {
        float distance = Vector3.Distance(player.transform.position, doorLock.transform.position);
        return distance <= maxDistance;
    }
}