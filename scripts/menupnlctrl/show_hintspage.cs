using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_hintspage : MonoBehaviour
{

    public GameObject Panel, hinttxt;
    public GameObject P2_3, P4_5, P6_7;
    public GameObject hbtn, hbtnA, hbtnB, hbtnC;
    Button hbtn1;
    public bool actcntxt;
    private int coincnt;

    public void Onback_menuepage()
    {

        if (actcntxt)
        {


            actcntxt = false;
            Panel.SetActive(true);
            P2_3.SetActive(false);
            P4_5.SetActive(false);
            P6_7.SetActive(true);


        }

        else
        {

            actcntxt = true;
            Panel.SetActive(true);
            P2_3.SetActive(true);
            P4_5.SetActive(false);
            P6_7.SetActive(false);

        }

    }

    public void Onreturn_game()
    {

        if (actcntxt)
        {


            actcntxt = false;
            Panel.SetActive(true);
            P2_3.SetActive(false);
            P4_5.SetActive(false);
            P6_7.SetActive(true);


        }

        else
        {

            actcntxt = true;
            Panel.SetActive(false);
            P2_3.SetActive(false);
            P4_5.SetActive(false);
            P6_7.SetActive(false);

        }

    }

    public void Ongotten_hints()
    {

        if (coincnt >= 5) hbtn1.interactable = true;
        else hbtn1.interactable = false;

    }

    public void Onshow_gainedhints()
    {

        if (hinttxt.activeSelf) hinttxt.SetActive(false);
        else hinttxt.SetActive(true);

    }

}
