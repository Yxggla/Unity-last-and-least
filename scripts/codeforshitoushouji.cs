using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeforshitoushouji : MonoBehaviour
{
    public Slider shitoushoujislider; // 血量滑动条
    public GameObject nextpanel; // 下一个
    public GameObject kongge; // 下一个
    public Text shitouNumber;
    public bool full=false;

    public GameObject xiaoshuaipanel;
    // Start is called before the first frame update
    private void Start()
    {
        // 初始化滑动条值
        shitoushoujislider.value = shitoushoujislider.minValue;
    }

    // Update is called once per frame
    public void shitouDamage()
    {
        if (shitoushoujislider.value < shitoushoujislider.maxValue)
        {
            shitoushoujislider.value += 1;
            shitouNumber.text=shitoushoujislider.value+" "+"/"+" "+shitoushoujislider.maxValue;
        }
        
        if (shitoushoujislider.value == shitoushoujislider.maxValue)
        {
            nextpanel.SetActive(true);
            kongge.SetActive(true);
            xiaoshuaipanel.SetActive(true);
            full = true;
        }
    }
}
