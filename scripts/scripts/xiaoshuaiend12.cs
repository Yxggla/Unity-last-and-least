using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiaoshuaiend12 : MonoBehaviour
{
    public GameObject nowpanel;
    public GameObject xiaoshuaipanel;
    public GameObject nltlight;
    public Material greenlightMaterial;
    // Update is called once per frame
    void Update()
    {
        if (nowpanel.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("绿了");
            nowpanel.SetActive(false);
            xiaoshuaipanel.SetActive(false);
            Renderer renderer = nltlight.GetComponent<Renderer>();
            renderer.material = greenlightMaterial;
        }
    }
}
