using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fabwxr : MonoBehaviour
{
    public bool wxrlive1=true;
    public bool wxrlive2=true;
    public bool wxrlive3=true;
    public GameObject wxr1;
    public GameObject wxr2;
    public GameObject wxr3;
    private bool gengxin=true;
    public jixvgame Jixvgame;
    public value playvalue;
    // Update is called once per frame
    void Update()
    {
        if (gengxin && Jixvgame.jxyxjr)
        {
            if (playvalue.wxr1==false)
            {
                Destroy(wxr1);
            }
            if (playvalue.wxr2==false)
            {
                Destroy(wxr2);
            }
            if (playvalue.wxr3==false)
            {
                Destroy(wxr3);
            }
            gengxin = false;
        }
        
        if (wxr1==null && wxrlive1)
        {
            wxrlive1 = false;
        }
        if (wxr2==null && wxrlive2)
        {
            wxrlive2 = false;
        }
        if (wxr3==null && wxrlive3)
        {
            wxrlive3 = false;
        }
    }
}
