using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Show_Menuepanel : MonoBehaviour
{

    Rigidbody2D ballrisidbody;

    public GameObject panel;
    public GameObject ballPrefab;
    public GameObject button1, button2, button3, button4, button5, button6;
    public float vec_x, vec_y;
    public static Show_Menuepanel instance;

    private void Awake()
    {

        if (instance != null) instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {

        ballrisidbody = ballPrefab.GetComponent<Rigidbody2D>();
        panel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onlick_Menue()
    {

        panel.SetActive(true);
        bbmanager bbnmg = GameObject.Find("Main Camera").GetComponent<bbmanager>();
        bbnmg.TogglePause();

    }

    public void Onlick_button1()
    {

        panel.SetActive(false);

    }

    public void Onlick_button5()
    {

        instanceblocks insbls = GameObject.Find("blocks").GetComponent<instanceblocks>();
        bbmanager bbnmg = GameObject.Find("Main Camera").GetComponent<bbmanager>();

        switch (bbmanager.nowlevel)
        {

            case 2:

                insbls.OutputLevel2map();

            break;

            case 3:

                insbls.OutputLevel3map();

            break;

            case 4:
            case 5:
            case 6:
            case 7:

                insbls.OutputLevel4_7map();

            break;

            default:
            break;

        }
        bbnmg.SetballStatus(ball1.Status.Restart);

    }

    public void Onlick_button6()
    {

        bbmanager bbnmg = GameObject.Find("Main Camera").GetComponent<bbmanager>();
        bbnmg.SetballStatus(ball1.Status.Restart);

    }

}