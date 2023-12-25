using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiaoshuaiend11 : MonoBehaviour
{
    public GameObject nowpanel;
    public GameObject xiaoshuaipanel;
    // Update is called once per frame
    void Update()
    {
        if (nowpanel.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            nowpanel.SetActive(false);
            xiaoshuaipanel.SetActive(false);
        }
    }
}
