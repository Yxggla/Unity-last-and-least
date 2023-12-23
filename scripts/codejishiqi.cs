using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class jishiqi : MonoBehaviour
{
    public Text countdownText; // 对应UI中的文本组件
    public float initialCountdownTime; // 初始倒计时时长
    private float countdownTime; // 当前倒计时时间
    public GameObject gameoverplane; // 游戏结束面板
    public GameObject startPanel; // 开始面板

    void Start()
    {
        countdownTime = initialCountdownTime;
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        // 等待直到startPanel不再活跃
        yield return new WaitUntil(() => !startPanel.activeSelf);

        while (countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString("F0") + "s";
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownText.text = "时间结束";
        gameoverplane.SetActive(true);
    }

    // 在其他地方触发的事件，增加倒计时时间
    public void AddTime(float timeToAdd)
    {
        countdownTime += timeToAdd;
    }

}