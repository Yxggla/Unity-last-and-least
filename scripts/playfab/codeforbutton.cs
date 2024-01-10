using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
public class codeforbutton : MonoBehaviour
{
    public InputField mail;

    public InputField psw;
    public InputField pswinputField;
    public Text shuchu;
    public GameObject newpenal;
    public GameObject nextpenal;
    public Text yonghutext;
    private void Start()
    {
        pswinputField.contentType = InputField.ContentType.Password;
    }
    // Start is called before the first frame update
    public void BindAccount()
    {
        shuchu.text = "";
        var registerRequest = new RegisterPlayFabUserRequest
        {
            Email = mail.text,
            Password = psw.text,
            RequireBothUsernameAndEmail = false
        };

        PlayFabClientAPI.RegisterPlayFabUser(registerRequest, OnRegisterSuccess, OnRegisterFailure);
    }

    private void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        Debug.Log("注册成功");
        shuchu.text = "注册成功";
        // 使用注册成功后获得的PlayFabId进行自定义登录
    }

    private void OnRegisterFailure(PlayFabError error)
    {
        Debug.LogError("注册失败: " + error.GenerateErrorReport());
        shuchu.text = "注册失败";
    }
    
    public void Login()
    {
        shuchu.text = "";
        var loginRequest = new LoginWithEmailAddressRequest
        {
            Email = mail.text,
            Password = psw.text
        };

        PlayFabClientAPI.LoginWithEmailAddress(loginRequest, OnLoginSuccess, OnLoginFailure);
    }

    private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("登录成功");
        shuchu.text = "登录成功";
        yonghutext.text = "用户名：" + mail.text;
        StartCoroutine(DelayedAction());
        // 登录成功后的逻辑
    }
    private IEnumerator DelayedAction()
    {
        // 等待2秒
        yield return new WaitForSeconds(2.0f);
        nextpenal.SetActive(true);
        newpenal.SetActive(false);
    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogError("登录失败: " + error.GenerateErrorReport());
        shuchu.text = "登录失败";
        // 登录失败的错误处理逻辑
    }
}
