using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using System.Collections.Generic;
using PlayFab.Internal;

public class SaveData : MonoBehaviour
{
    // 假设这些是玩家的当前状态数据
    public value playervalue;

    public bool save=false; 
    // 调用这个方法来保存和上传数据
    public void UploadPlayerData()
    {
        save = true;
        GameData gameData = new GameData
        {
            playerHealth = playervalue.playerHealth,
            remainingTime = playervalue.remainingTime,
            playerPosition = playervalue.playerPosition,
            wxrlive1=playervalue.wxr1,
            wxrlive2=playervalue.wxr2,
            wxrlive3=playervalue.wxr3,
            foodlive1=playervalue.food1,
            foodlive2=playervalue.food2,
            foodlive3=playervalue.food3,
        };

        // 将对象转换为 JSON 字符串
        string jsonData = JsonUtility.ToJson(gameData);

        // 创建更新数据请求
        UpdateUserDataRequest request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string> { { "GameData", jsonData } }
        };

        // 发送请求
        PlayFabClientAPI.UpdateUserData(request, OnGameDataSaved, OnError);
    }

    private void OnGameDataSaved(UpdateUserDataResult result)
    {
        Debug.Log("游戏数据保存成功！");
    }

    private void OnError(PlayFabError error)
    {
        Debug.LogError("游戏数据保存失败：" + error.ErrorMessage);
    }
}

[System.Serializable]
public class GameData
{
    public float playerHealth;
    public float remainingTime;
    public Vector3 playerPosition;
    public bool wxrlive1;
    public bool wxrlive2;
    public bool wxrlive3;
    public bool foodlive1;
    public bool foodlive2;
    public bool foodlive3;
}
