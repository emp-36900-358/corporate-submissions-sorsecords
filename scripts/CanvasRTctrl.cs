using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRTctrl : MonoBehaviour
{

    RectTransform RectTransform_get;

    // Start is called before the first frame update
    void Start()
    {

        RectTransform_get = GetComponent<RectTransform>();

    }

    void Update()
    {

        Vector3 scale = RectTransform_get.localScale;
        scale = new Vector3(1.0f, 1.0f ,0.0f);
        RectTransform_get.localScale = scale;

        Vector2 anchors_Minsize = RectTransform_get.anchorMin;
        Vector2 anchors_Maxsize = RectTransform_get.anchorMax;
        anchors_Minsize = new Vector2(0.5f, 0.5f);
        anchors_Maxsize = new Vector2(0.5f, 0.5f);
        RectTransform_get.anchorMin = anchors_Minsize;
        RectTransform_get.anchorMax = anchors_Maxsize;

    }

}
