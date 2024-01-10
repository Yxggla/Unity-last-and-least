using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class codejishiqi : MonoBehaviour
{
    public Text countdownText; // 对应UI中的文本组件
    public float initialCountdownTime=60f; // 初始倒计时时长
    public float countdownTime; // 当前倒计时时间
    public codeforhealthbar health;
    public value playvalue;
    private bool gengxin=true;
    public jixvgame Jixvgame;
    public void Update()
    {
        // 初始化滑动条值
        if (gengxin && Jixvgame.jxyxjr)
        {
            Debug.Log("xueliang");
            Debug.Log(playvalue.remainingTime);
            countdownTime =playvalue.remainingTime;
            gengxin = false;
            initialCountdownTime=countdownTime;
        }
        
    }
    public void StartCountdownTimer()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        countdownTime = initialCountdownTime;
        while (true)
        {
            countdownText.text = countdownTime.ToString("F0") + "s";
            yield return new WaitForSeconds(1f);
            countdownTime--;

            if (countdownTime <= 0)
            {
                health.TakeDamage();
                countdownTime = 60f;
            }
        }
    }


    // 在其他地方触发的事件，增加倒计时时间
    public void AddTime(float timeToAdd)
    {
        countdownTime += timeToAdd;
    }
    public void UpdateHealth(float newHealth)
    {
        health.healthSlider.value = newHealth;  // 假设 healthbar 有一个 Slider 组件
    }
}