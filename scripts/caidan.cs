using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caidan : MonoBehaviour
{
    public GameObject menuPanel; // 将菜单面板拖拽到这里
    public GameObject xiaoditucamera;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 切换菜单的可见性
            menuPanel.SetActive(!menuPanel.activeSelf);
            // 可选：暂停游戏，如果菜单是可见的
            if (menuPanel.activeSelf)
            {
                Time.timeScale = 0f; // 暂停游戏
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f; // 恢复游戏
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

    public void ResumeGame()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1f; // 恢复游戏
        Time.timeScale = 1f; // 恢复游戏
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void SaveGame()
    {
        // 添加保存游戏的代码
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void xiaoditu()
    {
         xiaoditucamera.SetActive(!xiaoditucamera.activeSelf);
    }
}
