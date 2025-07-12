using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shelfs : MonoBehaviour
{

    public GameObject ShelfA, ShelfB, ShelfC, ShelfD, ShelfE;

    public void Onscalup_Triger_C()
    {

        ShelfA.SetActive(false);
        ShelfB.SetActive(true);

    }

    public void Onscalup_Triger_D()
    {

        ShelfA.SetActive(false);
        ShelfC.SetActive(true);

    }

    public void Onscalup_Triger_E()
    {

        ShelfA.SetActive(false);
        ShelfD.SetActive(true);

    }

    public void Onscalup_Triger_F()
    {

        ShelfA.SetActive(false);
        ShelfE.SetActive(true);

    }

    public void Onscaldown_Triger_C()
    {

        ShelfB.SetActive(false);
        ShelfA.SetActive(true);

    }

    public void Onscaldown_Triger_D()
    {

        ShelfC.SetActive(false);
        ShelfA.SetActive(true);

    }

    public void Onscaldown_Triger_E()
    {

        ShelfD.SetActive(false);
        ShelfA.SetActive(true);

    }

    public void Onscaldown_Triger_F()
    {

        ShelfE.SetActive(false);
        ShelfA.SetActive(true);

    }

}
