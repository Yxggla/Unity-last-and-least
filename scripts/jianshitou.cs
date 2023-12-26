using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jianshitou : MonoBehaviour
{
    public codeforshitoushouji jianshitou1;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("stone"))
        {
            Debug.Log("1");
            jianshitou1.shitouDamage();
            Destroy(other.gameObject);
        }
    }
}
