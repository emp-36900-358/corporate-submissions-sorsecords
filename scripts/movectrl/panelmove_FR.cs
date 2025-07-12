using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelmove_FR : MonoBehaviour
{

    public void Onshow_final_result()
    {

        this.transform.localPosition = new Vector2(0, 1080);

    }

    public void Onreturn()
    {

        this.transform.localPosition = new Vector2(0, 0);

    }

}
