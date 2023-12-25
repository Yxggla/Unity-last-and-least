using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forxiaoshuaiend : MonoBehaviour
{

    public GameObject nowpanel;
    public GameObject xueliangPanel;
    public GameObject xiaoshuaipanel;
    public codejishiqi codejishiqi;
    // Update is called once per frame
    void Update()
    {
        if (nowpanel.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            nowpanel.SetActive(false);
            xiaoshuaipanel.SetActive(false);
            xueliangPanel.SetActive(true);
            codejishiqi.StartCountdownTimer();
            
        }
    }


}
