using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellets1 : MonoBehaviour
{

    PmManager_otherfanc other_mng;
    public int points;

    protected virtual void Eat()
    {

        other_mng = FindObjectOfType<PmManager_otherfanc>();

        if (other_mng == null)
        {
            Debug.LogError("PmManager_otherfanc Ç™ÉVÅ[Éìì‡Ç…ë∂ç›ÇµÇ‹ÇπÇÒÅI");
            return;
        }

        other_mng.EatenNormalpellets(this);

    }

    private void OnTriggerEnter2D(Collider2D othercol)
    {

        if (othercol.gameObject.layer == LayerMask.NameToLayer("PacMan"))
        {

            Eat();

        }

    }

}

