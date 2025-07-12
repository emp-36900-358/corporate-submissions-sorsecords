using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_passpanels : MonoBehaviour
{

    public GameObject hnttxt1, hnttxt2, hnttxt3;
    public GameObject panel1, panel2, panel3, panel4, panel5;
    public static show_passpanels instance;

    public void Onthelock_dk()
    {

        if(panel3.activeSelf) panel3.SetActive(false);
        else
        {

            hnttxt2.SetActive(true);
            panel3.SetActive(true);

        }

    }

    public void OnCAD()
    {

        if (panel5.activeSelf) panel5.SetActive(false);
        else
        {

            hnttxt3.SetActive(true);
            panel5.SetActive(true);

        }

    }


    public void Onthelock_mb()
    {

        if(panel1.activeSelf) panel1.SetActive(false);
        else
        {

            hnttxt1.SetActive(true);
            panel1.SetActive(true);

        }

    }


}
