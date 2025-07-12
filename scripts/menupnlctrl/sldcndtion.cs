using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sldcndtion : MonoBehaviour
{

    Slider Soundvol, Voicevol, SEvol;
    public static sldcndtion instance;

    private void Awake()
    {

        instance = this;

    }

    void Start()
    {

        Soundvol = GetComponent<Slider>();

        float maxvol1 = 100f, crtvol1 = 0f;

        Soundvol.maxValue = maxvol1;
        Soundvol.value = crtvol1;

        Voicevol = GetComponent<Slider>();

        float maxvol2 = 100f, crtvol2 = 0f;

        Voicevol.maxValue = maxvol2;
        Voicevol.value = crtvol2;

        SEvol = GetComponent<Slider>();

        float maxvol3 = 100f, crtvol3 = 0f;

        SEvol.maxValue = maxvol3;
        SEvol.value = crtvol3;

    }

    public void sldcndtionchd(float crtvol1, float crtvol2, float crtvol3)
    {

        apllysldvlu1.instance.apllysldvluchnd1(crtvol1);
        apllysldvlu2.instance.apllysldvluchnd2(crtvol2);
        apllysldvlu3.instance.apllysldvluchnd3(crtvol3);

    }

    public void Method()
    {

        Debug.Log("現在値：" + Soundvol.value);
        Debug.Log("現在値：" + Voicevol.value);
        Debug.Log("現在値：" + SEvol.value);

        if (Soundvol.value == 0) Debug.Log("サイレント状態です");
        else if(Voicevol.value == 0) Debug.Log("サイレント状態です");
        else if(SEvol.value == 0) Debug.Log("サイレント状態です");

    }

}
