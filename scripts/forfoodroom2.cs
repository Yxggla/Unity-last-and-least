using System.Collections;
using UnityEngine;

public class forfoodroom2 : MonoBehaviour
{
    public GameObject player; // 玩家对象
    public float disappearDistance = 2f; // 消失距离
    public float respawnTime = 5f; // 重新出现的时间
    public codejishiqi timerScript; // 计时器脚本
    public codeforhealthbar healthBarScript; // 假设您有一个 HealthBar 脚本
    public FoodManager foodManager; // 食物管理器
   

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= disappearDistance)
        {
            // 增加生存时间60秒
            timerScript.AddTime(60f);
            // 让游戏对象消失
            healthBarScript.AddHealth();
            foodManager.HideAndRespawn(gameObject);
        }
    }

  
}