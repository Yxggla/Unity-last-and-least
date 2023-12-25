using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forxiaoshuainpc : MonoBehaviour
{

    public GameObject nowpanel;
    public GameObject nextpanel;
    
    // Update is called once per frame
    void Update()
    {
        if (nowpanel.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            nextpanel.SetActive(true);
            nowpanel.SetActive(false);
        }
    }


}
