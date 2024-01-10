using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 导入场景管理命名空间

public class zaixianyouxi : MonoBehaviour
{
    public void LoadNewScene() 
    {
        SceneManager.LoadScene("lianjichangj"); // 将 "SceneName" 替换为您想要加载的场景名
    }
}