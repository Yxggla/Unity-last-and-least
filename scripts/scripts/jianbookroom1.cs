using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jianbookroom1 : MonoBehaviour
{
    public GameObject imgpaper1;

    public GameObject mimapanel;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("book1"))
        {
            Debug.Log("1");
            Destroy(other.gameObject);
            mimapanel.SetActive(true);
            imgpaper1.SetActive(true);
            
        }
    }
}
