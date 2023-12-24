using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class codejishiqi : MonoBehaviour
{
    public Text countdownText; // 对应UI中的文本组件
    public float initialCountdownTime; // 初始倒计时时长
    private float countdownTime; // 当前倒计时时间
    public GameObject gameoverplane; // 游戏结束面板
    public GameObject startPanel; // 开始面板
    public codeforhealthbar health;
    public GameObject xueliangPanel;

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        yield return new WaitUntil(() => xueliangPanel.activeSelf);
        countdownTime = initialCountdownTime;
        while (true) // 用无限循环替换原来的条件
        {
            countdownText.text = countdownTime.ToString("F0") + "s";
            yield return new WaitForSeconds(1f);
            countdownTime--;

            // 当计时器时间到0
            if (countdownTime <= 0)
            {
                health.TakeDamage();   // 造成伤害
                countdownTime = 60f;    // 重置计时器时间为6秒
            }
        }
    }


    // 在其他地方触发的事件，增加倒计时时间
    public void AddTime(float timeToAdd)
    {
        countdownTime += timeToAdd;
    }

}