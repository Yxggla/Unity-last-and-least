using System.Collections;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime; // 确保导入了这个命名空间

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); // 连接到 Photon 云服务
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master Server");
        RoomOptions roomOptions = new RoomOptions { MaxPlayers = 2 }; // 创建房间选项，设置最大玩家数为 2
        PhotonNetwork.JoinOrCreateRoom("test", roomOptions, TypedLobby.Default); // 创建或加入名为 "test" 的房间
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room!");
        // 在这里实例化玩家对象
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.LogError($"Failed to join room: {message}");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.LogError($"Failed to create room: {message}");
    }
}