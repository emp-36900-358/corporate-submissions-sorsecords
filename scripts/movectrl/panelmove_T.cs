using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelmove_T : MonoBehaviour
{


    public void Onshow_intro()
    {

        this.transform.localPosition = new Vector2(0, -1080);

    }

    public void OnBack()
    {

        this.transform.localPosition = new Vector2(0, 0);
    }

}
