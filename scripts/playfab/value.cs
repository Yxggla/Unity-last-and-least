using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class value : MonoBehaviour
{
    // 玩家的基本属性
    public float playerHealth;
    public float remainingTime;
    public Vector3 playerPosition ;
    public codeforhealthbar healthbar;
    public codejishiqi jishiqi;
    public PlayerController player;
    public jixvgame Jixvgame;
    public SaveData SaveData;
    public bool wxr1=true;
    public bool wxr2=true;
    public bool wxr3=true;
    public bool food1=true;
    public bool food2=true;
    public bool food3=true;
    public fabwxr forwxr;
    public food foodroom1;
    private void Update()
    {
        if (SaveData.save)
        {
            playerPosition = player.transform.position;
            playerHealth = healthbar.healthSlider.value;
            remainingTime = jishiqi.countdownTime;
            wxr1 = forwxr.wxrlive1;
            wxr2 = forwxr.wxrlive2;
            wxr3 = forwxr.wxrlive3;
            food1 = foodroom1.food1;
            food2 = foodroom1.food2;
            food3 = foodroom1.food3;
        }
    }

    // 用于从外部更新玩家健康值
    public void UpdateHealth(float newHealth)
    {
        playerHealth = newHealth;
        Debug.Log("value的");
        Debug.Log(playerHealth);
    }

    // 用于从外部更新剩余时间
    public void UpdateRemainingTime(float newTime)
    {
        remainingTime = newTime;
        Debug.Log("value的");
        Debug.Log(remainingTime);
    }

    // 用于从外部更新玩家位置
    public void UpdatePosition(Vector3 newPosition)
    {
        playerPosition = newPosition;
        Debug.Log("value的");
        Debug.Log(playerPosition);
    }
    
    public void UpdateWxrlive1(bool newwxrlive)
    {
        wxr1 = newwxrlive;
        Debug.Log("value的");
        Debug.Log(wxr1);
    }
    public void UpdateWxrlive2(bool newwxrlive)
    {
        wxr2 = newwxrlive;
        Debug.Log("value的");
        Debug.Log(wxr2);
    }
    public void UpdateWxrlive3(bool newwxrlive)
    {
        wxr3 = newwxrlive;
        Debug.Log("value的");
        Debug.Log(wxr3);
    }
    public void UpdateFood1(bool newfoodlive)
    {
        food1 = newfoodlive;
        Debug.Log("value的");
        Debug.Log(food1);
    }
    public void UpdateFood2(bool newfoodlive)
    {
        food2 = newfoodlive;
        Debug.Log("value的");
        Debug.Log(food2);
    }
    public void UpdateFood3(bool newfoodlive)
    {
        food3 = newfoodlive;
        Debug.Log("value的");
        Debug.Log(food3);
    }
}
