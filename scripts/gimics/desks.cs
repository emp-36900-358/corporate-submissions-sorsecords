using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class desks : MonoBehaviour
{

    public GameObject DeskA, DeskB, DeskC;

     public void Onscalup_Triger_A()
     {

        DeskA.SetActive(false);
        DeskB.SetActive(true);

     }

    public void Onscalup_Triger_B()
    {

        DeskA.SetActive(false);
        DeskC.SetActive(true);

    }

    public void Onscaldown_Triger_A()
    {

        DeskB.SetActive(false);
        DeskA.SetActive(true);

    }

    public void Onscaldown_Triger_B()
    {

        DeskC.SetActive(false);
        DeskA.SetActive(true);

    }

}
