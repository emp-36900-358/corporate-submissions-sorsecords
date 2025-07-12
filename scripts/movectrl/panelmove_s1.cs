using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelmove_s1 : MonoBehaviour
{

    public void Onfrom_the_bigining()
    {

        this.transform.localPosition = new Vector2(0, 1080);

    }

    public void Onback()
    {

        this.transform.localPosition = new Vector2(0, 0);

    }

}
