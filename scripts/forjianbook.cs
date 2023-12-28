using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class forjianbook : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject imgpaper3;
    public GameObject mimapanel;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            imgpaper3.SetActive(true);
            mimapanel.SetActive(true);
        }
    }
}
