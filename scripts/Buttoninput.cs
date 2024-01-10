using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Buttoninput : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField inputField; // 引用文本输入框
    public GameObject passwordPanel; // 密码面板
    public Text text; // 由按钮调用的方法，用于添加数字到输入框
    public DoorCont door; // 引用门的脚本
    public string rightpassword;
    public GameObject thistdoorlight;
    public GameObject thistdoorlight2;
    public Material greenlightMaterial;
    public GameObject xiaoshuaitext5;
    public GameObject xiaoshuaipanel;
    private bool tixing = false;
    private AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            passwordPanel.SetActive(false);
        }
    }
    public void AddNumberToInput(string number)
    {
        inputField.text += number; // 在现有文本后添加数字
    }
    public void ClearInput()
    {
        inputField.text = "";
    }
    public void SubmitPassword()
    {
        string inputPassword = inputField.text;

        // 判断密码是否正确
        if (inputPassword == rightpassword)
        {
            text.text = "Password is right!";
            Renderer renderer = thistdoorlight.GetComponent<Renderer>();
            Renderer renderer2 = thistdoorlight2.GetComponent<Renderer>();
            renderer.material = greenlightMaterial;
            renderer2.material = greenlightMaterial;
            StartCoroutine(WaitAndClosePanel(2.0f));
        }
        else
        {
            text.text = "Password is wrong!";
            inputField.text = "";
            // 在这里添加显示密码错误的提示的代码
        }
    }

    private IEnumerator WaitAndClosePanel(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        text.text = "";
        inputField.text = "";
        PlaySound();
        passwordPanel.SetActive(false); // 关闭密码面板
        door.Door(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (tixing==false)
        {
            xiaoshuaitext5.SetActive(true);
            xiaoshuaipanel.SetActive(true);
            tixing = true;
        }
        
    }
    public void PlaySound()
    {
        audioSource.Play();
    }
    
    
}
