using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class apllysldvlu3 : MonoBehaviour
{

    [SerializeField] private Slider v_sld3;
    [SerializeField] private Text v_text3;
    public static apllysldvlu3 instance;

    private void Awake()
    {

        instance = this;

    }

    void Start()
    {

        apllysldvluchnd3(v_sld3.value);

    }

    public void apllysldvluchnd3(float V_value3)
    {

        v_text3.text = V_value3.ToString("000");

    }

}
