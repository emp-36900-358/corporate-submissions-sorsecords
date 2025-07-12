using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_menuepage : MonoBehaviour
{

    public GameObject Panel;
    public GameObject P2_3, P4_5, P6_7;
    public GameObject mbtn, mbtn1, mbtn2, mbtn3, mbtn4, mbtn5;
    public bool actcntxt;

    public void Onto_hintpage()
    {

        if (actcntxt)
        {


            actcntxt = false;
            Panel.SetActive(true);
            P2_3.SetActive(true);
            P4_5.SetActive(false);
            P6_7.SetActive(false);


        }

        else
        {

            actcntxt = true;
            Panel.SetActive(true);
            P2_3.SetActive(false);
            P4_5.SetActive(false);
            P6_7.SetActive(true);

        }

    }

    public void Onto_settingpage()
    {

        if (actcntxt)
        {

            actcntxt = false;
            Panel.SetActive(true);
            P2_3.SetActive(true);
            P4_5.SetActive(false);
            P6_7.SetActive(false);


        }

        else
        {

            actcntxt = true;
            Panel.SetActive(true);
            P2_3.SetActive(false);
            P4_5.SetActive(true);
            P6_7.SetActive(false);


        }

    }


    public void Onback_game()
    {

        if (actcntxt)
        {


            actcntxt = false;
            Panel.SetActive(true);
            P2_3.SetActive(true);
            P4_5.SetActive(false);
            P6_7.SetActive(false);


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

    public void Onquit_gzme()
    {

        Application.Quit();

    }

    public void Onnow_savinng()
    {



    }

}
