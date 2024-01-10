using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    private bool gengxin=true;
    public jixvgame Jixvgame;
    public value playvalue;
    public GameObject food1;
    public GameObject food2;
    public GameObject food3;
    public bool foodlive1=true;
    public bool foodlive2=true;
    public bool foodlive3=true;
    void Update()
    {
        if (gengxin && Jixvgame.jxyxjr)
        {
            if (playvalue.food1==false)
            {
                Destroy(food1);
            }
            if (playvalue.food2==false)
            {
                Destroy(food2);
            }
            if (playvalue.food3==false)
            {
                Destroy(food3);
            }
            gengxin = false;
        }
        
        if (food1==null && foodlive1 )
        {
            foodlive1 = false;
        }
        if (food2==null && foodlive2)
        {
            foodlive2 = false;
        }
        if (food3==null && foodlive3)
        {
            foodlive3 = false;
        }
    }
}
