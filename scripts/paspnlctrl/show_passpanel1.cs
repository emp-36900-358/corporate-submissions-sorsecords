using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class show_passpanel1 : MonoBehaviour
{

    public Button numbtn1, numbtn2, numbtn3, numbtn4, numbtn5,
                  numbtn6, numbtn7, numbtn8, numbtn9, numbtn0,
                  okbtn;
    public Text wartxt, pastxt;
    public GameObject Panel, hnttxt, lockimg;

    private void Start()
    {
        Lobjbtnintcmng.path += PathThrough;
    }

    public void OnnumButton1()
    {
        pastxt.text += "1";
    }

    public void OnnumButton2()
    {
        pastxt.text += "2";
    }

    public void OnnumButton3()
    {
        pastxt.text += "3";
    }

    public void OnnumButton4()
    {
        pastxt.text += "4";
    }

    public void OnnumButton5()
    {
        pastxt.text += "5";
    }

    public void OnnumButton6()
    {
        pastxt.text += "6";
    }

    public void OnnumButton7()
    {
        pastxt.text += "7";
    }

    public void OnnumButton8()
    {
        pastxt.text += "8";
    }

    public void OnnumButton9()
    {
        pastxt.text += "9";
    }

    public void OnnumButton0()
    {
        pastxt.text += "0";
    }

    public void OnOKButton()
    {

        if (pastxt.text != "369")
        {

            wartxt.text = "パスコードが正しくありません。もう一度入れ直して下さい。";
            pastxt.text = "";

        }
        else
        {

            Debug.Log("unlocked");
            wartxt.text = "";
            Debug.Log(wartxt.text);
            Panel.SetActive(false);
            hnttxt.SetActive(false);
            lockimg.SetActive(false);
            Lobjbtnintcmng.path.Invoke();


        }

    }

    static void PathThrough()
    {

     
    }

}