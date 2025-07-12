using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWay : MonoBehaviour
{

    public GameObject owobj1, owobj2, owobj3, owobj4;

    private void OnCollisionStay2D(Collision2D owcol)
    {
        
        if(owcol.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {



        }

    }

}
