using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAlphacontroller : MonoBehaviour
{

    SpriteRenderer _tSR;
    Color _obgcolor; 

    // Start is called before the first frame update
    void Start()
    {

        _tSR = GetComponent<SpriteRenderer>();
        _obgcolor = _tSR.color;
        _obgcolor.a = 0.0f;
        _tSR.color = _obgcolor;

    }

    // Update is called once per frame
    void Update()
    {



    }
}
