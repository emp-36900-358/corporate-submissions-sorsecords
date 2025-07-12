using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_passpanel2 : MonoBehaviour
{

    public GameObject Panel, hnttxt, lockimg;
    public Text wartxt;
    public Image btn1, btn2, btn3, btnOk;
    public Sprite[] marksSprites;
    enum Mark { maru, sankaku, daia, hosi }
    Mark crntMark1 = Mark.maru;
    Mark crntMark2 = Mark.maru;
    Mark crntMark3 = Mark.maru;

    private void Start()
    {
        RandomizeSprites(); 
        Lobjbtnintcmng.path += PathThrough;

    }

    void RandomizeSprites()
    {
        // Generate 3 random numbers
        int randomNum1 = Random.Range(0, 4);
        int randomNum2 = Random.Range(0, 4);
        int randomNum3 = Random.Range(0, 4);

        // Set the current marks using the random numbers
        crntMark1 = (Mark)randomNum1;
        crntMark2 = (Mark)randomNum2;
        crntMark3 = (Mark)randomNum3;

        // Set the sprites of the buttons using the current marks
        btn1.sprite = marksSprites[(int)crntMark1];
        btn2.sprite = marksSprites[(int)crntMark2];
        btn3.sprite = marksSprites[(int)crntMark3];
    }

    public void OnmarkButtons(int pos)
    {
        changeimg(pos);
        showMarkimg(pos);
    }

    public void OnOKButton()
    {
        if (crntMark1 != Mark.hosi && (crntMark2 != Mark.hosi && crntMark3 != Mark.daia))
        {
            wartxt.text = "パスコードが正しくありません。もう一度入れ直して下さい。";
        }
        else
        {
            Debug.Log("unlocked");
            wartxt.text = "";
            Debug.Log(wartxt.text);
            Panel.SetActive(false);
            hnttxt.SetActive(false);
            lockimg.SetActive(false);
            Lobjbtnintcmng.path.Invoke();
        }
    }

    void showMarkimg(int pos)
    {

        switch (pos)
        {
            case 1:
                crntMark1++;
                break;
            case 2:
                crntMark2++;
                break;
            case 3:
                crntMark3++;
                break;
        }


    }

    void changeimg(int pos)
    {
        switch (pos)
        {
            case 0:
                SwapSprites(ref btn1, ref crntMark1, ref crntMark2);
                break;
            case 1:
                SwapSprites(ref btn2, ref crntMark2, ref crntMark3);
                break;
            case 2:
                SwapSprites(ref btn3, ref crntMark3, ref crntMark1);
                break;
        }
    }

    void SwapSprites(ref Image btn, ref Mark mark1, ref Mark mark2)
    {
        // Swap the sprites
        Sprite tempSprite = btn.sprite;
        btn.sprite = marksSprites[(int)mark2];
        marksSprites[(int)mark2] = tempSprite;

        // Swap the current marks
        Mark tempMark = mark1;
        mark1 = mark2;
        mark2 = tempMark;
    }

    static void PathThrough()
    {


    }

}