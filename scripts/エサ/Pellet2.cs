using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Pellet2:Pellets1
{

    PmManager_otherfanc of_mng;
    public float duration = 8.0f;

    protected override void Eat()
    {

        of_mng = FindObjectOfType<PmManager_otherfanc>();

        if (of_mng == null)
        {
            Debug.LogError("PmManager_otherfanc Ç™ÉVÅ[Éìì‡Ç…ë∂ç›ÇµÇ‹ÇπÇÒÅI");
            return;
        }

        of_mng.Eatenpowerpellets(this);
    }

}
