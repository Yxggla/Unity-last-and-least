using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room2xiaoshuai : MonoBehaviour
{
    public GameObject nowpanel;
    public GameObject xiaoshuaipanel;
    public GameObject gongge;
    public bool canDisappear;

    public GameObject shitoupanel;
    
    // Update is called once per frame
    private void Start()
    {
        canDisappear = false;
    }

    void Update()
    {
        if (nowpanel.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            nowpanel.SetActive(false);
            xiaoshuaipanel.SetActive(false);
            canDisappear = true;
            gongge.SetActive(false);
            shitoupanel.SetActive(true);
        }
    }
}
