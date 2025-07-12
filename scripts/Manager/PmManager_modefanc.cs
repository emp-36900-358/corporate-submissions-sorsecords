using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class PmManager_modefanc : MonoBehaviour
{

    private PmManager mng;
    private PmManager_otherfanc mng_of;

    public PmManager Mng { get { return mng; } }

    private void Awake() // Start() �ł͂Ȃ� Awake() �ɕύX
    {

        mng = GameObject.Find("Main Camera").GetComponent<PmManager>();

        if (mng == null)
        {

            Debug.LogError("PmManager: mng (PmManager) �� null �ł��B���������m�F���Ă��������B");
            return;
        }

        mng_of = GameObject.Find("Main Camera").GetComponent<PmManager_otherfanc>();

        if (mng_of == null)
        {

            Debug.LogError("PmManager_modefanc: PmManager_otherfanc ��������܂���BMain Camera �ɃA�^�b�`����Ă��܂����H");
            return;
        }
    }

    public void NewGame()
    {

        mng_of.Setscore(0);
        mng_of.SetLife(3);
        mng_of.InitGame();

    }

    public void IdolScrean() 
    {

        mng.txtmap1.gameObject.SetActive(true);

        foreach (Transform pellet in mng.meal)
        {
            pellet.gameObject.SetActive(true);
        }

        for (int i = 0; i < Mng.enemies.Length; i++)
        {
            if (mng.enemies[i] != null)
            {
                mng.enemies[i].gameObject.SetActive(false);
                Debug.Log($"�G {i} ({mng.enemies[i].name}) ���\���ɂ��܂����B");
            }
            else
            {
                Debug.LogWarning($"Mng.enemies[{i}] �� null �ł��B");
            }
        }

        mng.player.gameObject.SetActive(false);

    }

    public void StartScrean() 
    {


        mng .txtmap3.gameObject.SetActive(true);
        mng.txtmap1.gameObject.SetActive(true);

        foreach (Transform pellet in Mng.meal)
        {
            pellet.gameObject.SetActive(true);
        }

        for (int i = 0; i < Mng.enemies.Length; i++)
        {
            if (mng.enemies[i] != null)
            {
                mng.enemies[i].gameObject.SetActive(false);
                Debug.Log($"�G {i} ({mng.enemies[i].name}) ���\���ɂ��܂����B");
            }
            else
            {
                Debug.LogWarning($"Mng.enemies[{i}] �� null �ł��B");
            }
        }

        mng.player.gameObject.SetActive(false);

    }

    public void ReadyScrean() 
    {

        mng.txtmap3.gameObject.SetActive(false);
        mng.txtmap1.gameObject.SetActive(true);

        NewGame();

    }

    public void GameOver()
    {

        mng.overflg = true;
        Debug.Log(mng.overflg);
        for (int i = 0; i < Mng.enemies.Length; i++) {
            if (mng.enemies[i] != null)
            {
                mng.enemies[i].gameObject.SetActive(false);
                Debug.Log($"�G {i} ({mng.enemies[i].name}) ���\���ɂ��܂����B");
            }
            else
            {
                Debug.LogWarning($"Mng.enemies[{i}] �� null �ł��B");
            }
        }

        mng.player.gameObject.SetActive(false);
        Mng.txtmap2.gameObject.SetActive(true);

    }

}
