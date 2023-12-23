using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forfood : MonoBehaviour
{
    public GameObject player; // 玩家对象
    public float disappearDistance = 3f; // 消失距离
    public jishiqi timerScript; // 计时器脚本
    public codeforhealthbar healthBarScript; // 假设您有一个 HealthBar 脚本
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= disappearDistance)
        {
            // 增加生存时间60秒
            timerScript.AddTime(60f);
            // 让游戏对象消失
            gameObject.SetActive(false);
            healthBarScript.AddHealth();
        }
    }
}
