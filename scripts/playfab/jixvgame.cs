using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using System.Collections.Generic;
using UnityEngine.UI;

public class jixvgame : MonoBehaviour
{
    
    public GameObject nowPanel; // 开始面板
    public codeforcamera1 Codeforcamera1;
    public GameObject camrera;
    public GameObject xiaoshuai1;
    public GameObject xiaoshuaipanel;
    public value playervalue;
    public bool jxyx=false;
    public bool jxyxjr=false;

    public Text jxyxbuttontext;
    // Start is called before the first frame update
  
    public void LoadGameData()
    {
        GetUserDataRequest request = new GetUserDataRequest();
        PlayFabClientAPI.GetUserData(request, OnDataReceived, OnError);
        jxyx = true;
        jxyxbuttontext.text = "正在加载游戏中";
        if (jxyxjr)
        {
            nowPanel.SetActive(false);
            camrera.SetActive(true);
            Codeforcamera1.StartGame();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            xiaoshuaipanel.SetActive(true);
            xiaoshuai1.SetActive(true);
        }
    }

    private void OnDataReceived(GetUserDataResult result)
    {
        if (result.Data != null && result.Data.ContainsKey("GameData"))
        {
            string jsonData = result.Data["GameData"].Value;
            GameData gameData = JsonUtility.FromJson<GameData>(jsonData);
            // 应用游戏数据
            ApplyGameData(gameData);
            jxyxbuttontext.text = "加载成功，点击进入";
            jxyxjr = true;
        }
    }

    private void OnError(PlayFabError error)
    {
        Debug.LogError("数据加载失败：" + error.ErrorMessage);
    }

    private void ApplyGameData(GameData gameData)
    {
        playervalue.UpdateHealth(gameData.playerHealth);
        playervalue.UpdatePosition(gameData.playerPosition);
        playervalue.UpdateRemainingTime(gameData.remainingTime);
        playervalue.UpdateWxrlive1(gameData.wxrlive1);
        playervalue.UpdateWxrlive2(gameData.wxrlive2);
        playervalue.UpdateWxrlive3(gameData.wxrlive3);
        playervalue.UpdateFood1(gameData.foodlive1);
        playervalue.UpdateFood2(gameData.foodlive2);
        playervalue.UpdateFood3(gameData.foodlive3);
    }
}
