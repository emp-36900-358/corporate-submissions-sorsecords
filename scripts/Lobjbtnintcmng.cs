using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void PathThroghpasses();

public class Lobjbtnintcmng : MonoBehaviour
{

    public GameObject nowlockImg;
    public Button lockiImgBtn;
    public static PathThroghpasses path;

    // Start is called before the first frame update
    void Start()
    {

        Setapllaybtnint(false);

        path += PathThroghpasses;

    }

    public void PathThroghpasses()
    {

        Setapllaybtnint(true);


    }

    public void Setapllaybtnint(bool pathCheck)
    {

           lockiImgBtn.interactable = pathCheck;

    }

}
