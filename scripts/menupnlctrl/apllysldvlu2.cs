using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class apllysldvlu2 : MonoBehaviour
{

    [SerializeField] private Slider v_sld2;
    [SerializeField] private Text v_text2;
    public static apllysldvlu2 instance;

    private void Awake()
    {

        instance = this;

    }

    void Start()
    {

        apllysldvluchnd2(v_sld2.value);

    }

    public void apllysldvluchnd2(float V_value2)
    {

        v_text2.text = V_value2.ToString("000");

    }

}
