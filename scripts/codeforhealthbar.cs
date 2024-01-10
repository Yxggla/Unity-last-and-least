using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeforhealthbar : MonoBehaviour
{
    
    public Slider healthSlider; // 血量滑动条
    public GameObject gameOverPanel; // 游戏失败面板
    public Text healthNumber;
    public value playvalue;
    private bool gengxin=true;
    public jixvgame Jixvgame;
    public void Update()
    {
        // 初始化滑动条值
        if (gengxin && Jixvgame.jxyxjr)
        {
            healthSlider.value =playvalue.playerHealth;
            gengxin = false;
            healthNumber.text=healthSlider.value+" "+"/"+" "+healthSlider.maxValue;
        }
        
    }

    // 减少血量
    public void TakeDamage()
    {
        if (healthSlider.value > healthSlider.minValue)
        {
            healthSlider.value -= 1;
            healthNumber.text=healthSlider.value+" "+"/"+" "+healthSlider.maxValue;
        }

        // 检查是否血量为0，触发游戏失败逻辑
        if (healthSlider.value == healthSlider.minValue)
        {
            GameOver();
        }
    }

    // 游戏失败逻辑
    void GameOver()
    {
        // 激活游戏失败面板
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameOverPanel.SetActive(true);

        // 在这里可以添加其他游戏失败的逻辑
        Debug.Log("Game Over");
    }

    public void AddHealth()
    {
        if (healthSlider.value < healthSlider.maxValue)
        {
            healthSlider.value += 1;
            healthNumber.text=healthSlider.value+" "+"/"+" "+healthSlider.maxValue;
        }

        
    }
}
