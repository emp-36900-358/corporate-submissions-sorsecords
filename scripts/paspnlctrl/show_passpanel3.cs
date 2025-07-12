using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_passpanel3 : MonoBehaviour
{
    public GameObject panel, hintText, lockimg;
    public Text warningText;
    public Button btn;
    public Button[] buttons;
    public Color[] colors;

    private void Start()
    {

        Lobjbtnintcmng.path += PathThrough;

        for (int i = 0; i < buttons.Length; i++)
        {

            SetButtonColor(i, Color.white);
            int index = i;  // ローカル変数にインデックスを保存する
            buttons[index].onClick.AddListener(() => OnColorButtonClicked(index));

        }

    }

    public void OnColorButtonClicked(int buttonIndex)
    {

        SetButtonColor(buttonIndex, GetRandomColor());

    }

    void SetButtonColor(int buttonIndex, Color newColor)
    {
        if (buttonIndex < buttons.Length)
        {
            ColorBlock colorBlock = buttons[buttonIndex].colors;
            colorBlock.normalColor = newColor;
            buttons[buttonIndex].colors = colorBlock;
        }
    }

    Color GetRandomColor()
    {
        int index = Random.Range(0, colors.Length);
        return colors[index];
    }

    public void OnOKButton()
    {
        bool isCorrect = false;
        for (int i = 0; i < buttons.Length; i++)
        {
            if ((buttons[i].colors.normalColor == Color.red && i == 0) &&
                (buttons[i].colors.normalColor == Color.blue && i == 1) &&
                (buttons[i].colors.normalColor == Color.green && i == 2))
            {

                isCorrect = true;
                
            }
          
            else
            {

                isCorrect = false;
                break;

            }
        }

        if (isCorrect)
        {

            Debug.Log("unlocked");
            warningText.text = "";
            panel.SetActive(false);
            hintText.SetActive(false);
            lockimg.SetActive(false);
            Lobjbtnintcmng.path.Invoke();

        }
        else
        {

            warningText.text = "パスコードが正しくありません。もう一度入れ直してください。";
            for (int i = 0; i < buttons.Length; i++)
            {
                SetButtonColor(i, Color.white);
            }

        }

        warningText.text = "";

    }

    static void PathThrough()
    {


    }

}
