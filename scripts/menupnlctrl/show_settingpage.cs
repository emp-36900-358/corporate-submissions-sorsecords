using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_settingpage : MonoBehaviour
{

    public GameObject Panel, voltxt1, voltxt2, voltxt3;
    public GameObject P2_3, P4_5, P6_7;
    public GameObject sbtn1, sbtn2;
    public GameObject svolsld1, svolsld2, svolsld3;
    public GameObject stgl1, stgl2, stgl3;
    public bool actcntxt;

    public void Onback_menuepage()
    {

        if (actcntxt)
        {


            actcntxt = false;
            Panel.SetActive(true);
            P2_3.SetActive(false);
            P4_5.SetActive(true);
            P6_7.SetActive(false);


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

    public void Onback_game()
    {

        if (actcntxt)
        {


            actcntxt = false;
            Panel.SetActive(true);
            P2_3.SetActive(false);
            P4_5.SetActive(true);
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

    public void vluchdof_Soundvol(float crtvol1)
    {

        apllysldvlu1.instance.apllysldvluchnd1(crtvol1);

    }

    public void vluchdof_Voicevol(float crtvol2)
    {

        apllysldvlu2.instance.apllysldvluchnd2(crtvol2);

    }

    public void vluchdof_SEvol(float crtvol3)
    {

        apllysldvlu3.instance.apllysldvluchnd3(crtvol3);

    }

}
