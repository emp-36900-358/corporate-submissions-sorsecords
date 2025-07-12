using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bbmanager : MonoBehaviour
{

    bool isGamePaused = false;
    float ballresponetimer, balldeadtimer;

    public GameObject ballPrefab;
    public Text Lvtxt, lifetxt, scoretxt;
    public float responeleachtime, deadleachtime;

    public static int totalscore, nowlife,nowlevel;
    public static int blocklife;

    ball1.Status ballStatus;
    instanceblocks.Status blockStatus;
    Vector3 ballpos = new Vector3(0.0f, -1.8f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {

        ballStatus = ball1.Status.Fine;
        blockStatus = instanceblocks.Status.Fine;
        ballresponetimer = 0.0f;
        balldeadtimer = 0.0f;
        Lvtxt.text = "Level:    1";
        lifetxt.text = "Life:   1000";
        scoretxt.text = "score:    0";
        totalscore = 0;
        nowlife = 1000;
        nowlevel = 1;
        instanceblocks insb = GameObject.Find("blocks").GetComponent<instanceblocks>();
        block _block = FindObjectOfType<block>();


        switch (_block.blockType)
        {

            case block.BlockType.barrier:

                blocklife = 3;

            break;

            case block.BlockType.trans:

                blocklife = 0;
                SetblockStatus(instanceblocks.Status.Fine);

            break;

            default:

                blocklife = 1;

            break;


        }

        switch (nowlevel)
        {


            case 1:

                instanceblocks.instancecnt = 21;
                Debug.Log("現在インスタンス化されているブロックの数:" + instanceblocks.instancecnt + "個");

            break;

            case 2:

                instanceblocks.instancecnt = 28;
                Debug.Log("現在インスタンス化されているブロックの数:" + instanceblocks.instancecnt + "個");

            break;

            case 3:
            case 4:
            case 5:
            case 6:
            case 7:


                instanceblocks.instancecnt = 35;
                Debug.Log("現在インスタンス化されているブロックの数:" + instanceblocks.instancecnt + "個");

                break;


            case 0:

                instanceblocks.instancecnt = 1;
                Debug.Log("現在インスタンス化されているブロックの数:" + instanceblocks.instancecnt + "個");

           break;

        }

        Instanseball();

    }
    // Update is called once per frame
    void Update()
    {
        switch(ballStatus)
        {

            case ball1.Status.Damaged:

                ballresponetimer += Time.deltaTime;

                if (ballresponetimer >= responeleachtime)
                {

                    Debug.Log(ballStatus);
                    ballresponetimer = 0.0f;
                    Instanseball();
                    ballStatus = ball1.Status.Fine;

                }
                break;
                
           case ball1.Status.Dead:

                balldeadtimer += Time.deltaTime;

                if (balldeadtimer >= deadleachtime)
                {

                    Debug.Log(ballStatus);
                    SceneManager.LoadScene("gameover");
                    balldeadtimer = 0.0f;

                }

          break;

          case ball1.Status.Restart:

                SceneManager.LoadScene("main game");
                TogglePause();
                ballStatus = ball1.Status.Fine;

          break;

          case ball1.Status.Clear:

                instanceblocks insb = GameObject.Find("blocks").GetComponent<instanceblocks>();
                
                switch(nowlevel)
                {

                    case 0:

                        //SceneManager.LoadScene("gameclear");
                        Debug.Log(ballStatus);
                        Levelup(nowlevel);
                        Sublife(nowlife);
                        insb.OutputLevel1map();
                        Instanseball();                ballStatus = ball1.Status.Fine;
                        ballStatus = ball1.Status.Fine;

                        break;

                    case 1:

                        //SceneManager.LoadScene("gameclear");
                        Debug.Log(ballStatus);
                        Levelup(nowlevel);
                        Sublife(nowlife);
                        insb.OutputLevel2map();
                        Instanseball();
                        ballStatus = ball1.Status.Fine;


                        break;

                    case 2:

                        //SceneManager.LoadScene("gameclear");
                        Debug.Log(ballStatus);
                        Levelup(nowlevel);
                        Sublife(nowlife);
                        insb.OutputLevel3map();
                        Instanseball(); 
                        ballStatus = ball1.Status.Fine;

                        break;

                    case 3:

                        //SceneManager.LoadScene("gameclear");
                        Debug.Log(ballStatus);
                        Levelup(nowlevel);
                        Sublife(nowlife);
                        insb.OutputLevel4_7map();
                        Instanseball();
                        ballStatus = ball1.Status.Fine;

                        break;


                    case 4:

                        //SceneManager.LoadScene("gameclear");
                        Debug.Log(ballStatus);
                        Levelup(nowlevel);
                        Sublife(nowlife);
                        insb.OutputLevel4_7map();
                        Instanseball();
                        ballStatus = ball1.Status.Fine;

                        break;


                    case 5:

                        //SceneManager.LoadScene("gameclear");
                        Debug.Log(ballStatus);
                        Levelup(nowlevel);
                        Sublife(nowlife);
                        insb.OutputLevel4_7map();
                        Instanseball();
                        ballStatus = ball1.Status.Fine;

                        break;


                    case 6:

                        //SceneManager.LoadScene("gameclear");
                        Debug.Log(ballStatus);
                        Levelup(nowlevel);
                        Sublife(nowlife);
                        insb.OutputLevel4_7map();
                        Instanseball();
                        ballStatus = ball1.Status.Fine;

                        break;

                }
                break;

        }

        switch (blockStatus)
        {

            case instanceblocks.Status.Dead:
                switch(nowlevel)
                {

                   case 0:
                        if (instanceblocks.instancecnt == 0)
                        {

                            Debug.Log("現在インスタンス化されているブロックの数:" + instanceblocks.instancecnt + "個");

                        }
                   break;

                   default:
                        if(instanceblocks.instancecnt == 0)
                        { 

                             Debug.Log("現在インスタンス化されているブロックの数:"　+ instanceblocks.instancecnt + "個");
                            ballStatus = ball1.Status.Clear;

                        }
                        else
                        {

                             Debug.Log("現在インスタンス化されているブロックの数:" + instanceblocks.instancecnt + "個");
                             blockStatus = instanceblocks.Status.Fine;

                        }
                    break;

                }

                break;

        }

    }

    public void Instanseball()
    {
        GameObject obj = Instantiate(ballPrefab, ballpos, Quaternion.identity);
        ball1 ball = obj.GetComponent<ball1>();
        ball.injectionball();
    }

    public void Addscore(int plusScore)
    {

        totalscore += plusScore;
        scoretxt.text = "score:    " + totalscore.ToString();

    }

    public void OnBlockDestroyed()
    {

        instanceblocks.instancecnt--;

    }
    
    public void SetballStatus(ball1.Status bs)
    {

        ballStatus = bs;
       if(ballStatus == ball1.Status.Clear) Debug.Log(ballStatus);

    }

    public void SetblockStatus(instanceblocks.Status bls)
    {

        blockStatus = bls;

    }

    public void Sublife(int life)
    {

        if(ballStatus == ball1.Status.Clear)
        {

            lifetxt.text = "nowlife:    " + nowlife.ToString();

        }
        else 
        {

            nowlife -= life;
            lifetxt.text = "nowlife:    " + nowlife.ToString();
            Debug.Log("現在のlife = " + nowlife);

        }

    }


    public void Subblocklife(int life)
    {

        if (blockStatus == instanceblocks.Status.Fine || blocklife <= 0)
        {

            blocklife = life;

        }
        else
        {

            blocklife  = life;
            blocklife = life - 1;

        }

    }

    public void Levelup(int level)
    {

        if (ballStatus == ball1.Status.Clear)
        {

            nowlevel =  level + 1;
            Lvtxt.text = "level:    " + nowlevel.ToString();
            Debug.Log("現在のlevel = " + nowlevel);

        }

    }

    public void TogglePause()
    {

        if (ballStatus != ball1.Status.Clear)
        {

            isGamePaused = !isGamePaused;

            if (isGamePaused)
            {

                PauseGame();

            }
            else
            {

                ResumeGame();

            }

        }
        else ResumeGame();

    }

    void PauseGame()
    {
        Time.timeScale = 0f; // ゲームを停止
        // 他に必要な一時停止時の処理を追加することができます
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // ゲームを再開
        // 他に必要な再開時の処理を追加することができます
    }
}
