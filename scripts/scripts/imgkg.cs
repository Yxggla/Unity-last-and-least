using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imgkg : MonoBehaviour
{
    public GameObject nowpanel;
    public GameObject mimapanel;
    // Update is called once per frame
    void Update()
    {
        if (nowpanel.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            nowpanel.SetActive(false);
            mimapanel.SetActive(false);
        }
    }
    
}
