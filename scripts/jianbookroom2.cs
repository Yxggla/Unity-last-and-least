using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jianbookroom2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject imgpaper2;
    public GameObject mimapanel;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("book2"))
        {
            Debug.Log("2");
            Destroy(other.gameObject);
            mimapanel.SetActive(true);
            imgpaper2.SetActive(true);
            
        }
    }
}
