using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opsets : MonoBehaviour
{

    public Text btntxt;
    public GameObject Panel, Panel1;
    public GameObject P2_3, P4_5, P6_7;
    public GameObject triger, btn, btn1, btn2, btn3, btn4, btn5, btn6;
    public bool trgcntxt = false, actcntxt = false;

    public void OnOC_Triger()
    {

        RectTransform transform = Panel.GetComponent<RectTransform>();
        float w = transform.sizeDelta.x;
        float h = transform.sizeDelta.y;

        if (trgcntxt)
        {

            trgcntxt = false;
            triger.GetComponentInChildren<Text>().text = ">-";
            transform.sizeDelta = new Vector2(1920, 180);
            Panel.transform.localPosition = new Vector2(0, 470);
            Panel.SetActive(true);
            triger.SetActive(true);
            btn.SetActive(true);
            btn1.SetActive(true);
            btn2.SetActive(true);
            btn3.SetActive(true);
            btn4.SetActive(true);
            btn5.SetActive(true);
            btn6.SetActive(true);

        }

        else
        {

            trgcntxt = true;
            triger.GetComponentInChildren<Text>().text = "-<";
            transform.sizeDelta = new Vector2(208, 180);
            Panel.transform.localPosition = new Vector2(800,270);
            Panel.SetActive(true);
            triger.SetActive(true);
            btn.SetActive(false);
            btn1.SetActive(false);
            btn2.SetActive(false);
            btn3.SetActive(false);
            btn4.SetActive(false);
            btn5.SetActive(false);
            btn6.SetActive(false);


        }


    }

    public void Onsetting_button()
    {

        if(actcntxt)
        {

            actcntxt = false;
            Panel1.SetActive(false);
            P2_3.SetActive(false);
            P4_5.SetActive(false);
            P6_7.SetActive(false);

        }
        else
        {

            actcntxt = true;
            Panel1.SetActive(true);
            P2_3.SetActive(false);
            P4_5.SetActive(true);
            P6_7.SetActive(false);


        }

    }

    public void Onmenue_button()
    {

        if (actcntxt)
        {

            actcntxt = false;
            Panel1.SetActive(false);
            P2_3.SetActive(false);
            P4_5.SetActive(false);
            P6_7.SetActive(false);

        }
        else
        {

            actcntxt = true;
            Panel1.SetActive(true);
            P2_3.SetActive(true);
            P4_5.SetActive(false);
            P6_7.SetActive(false);

        }

    }

    public void Onsave_button()
    {


    }

    public void Onhints_button()
    {

       if (actcntxt)
        {

            actcntxt = false;
            Panel1.SetActive(false);
            P2_3.SetActive(false);
            P4_5.SetActive(false);
            P6_7.SetActive(false);

        }
        else
        {

            actcntxt = true;
            Panel1.SetActive(true);
            P2_3.SetActive(false);
            P4_5.SetActive(false);
            P6_7.SetActive(true);

        }

    } 


    public void Onexit_button()
    {

        Application.Quit();

    }

}
