using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class apllysldvlu1 : MonoBehaviour
{

    [SerializeField] private Slider v_sld1;
    [SerializeField] private Text v_text1;
    public static apllysldvlu1 instance;

    private void Awake()
    {

        instance = this;

    }

    void Start()
    {

        apllysldvluchnd1(v_sld1.value);

    }

    public void apllysldvluchnd1(float V_value1)
    {

        v_text1.text = V_value1.ToString("000");

    }

}
