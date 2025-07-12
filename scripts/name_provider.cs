using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class name_provider : MonoBehaviour
{

    public InputField inputField;
    public Text outputText;

    public void onfield()
    {
        if (inputField != null && outputText != null)
        {
            outputText.text = inputField.text;
        }
    }

    public void EndInputText()
    {
        if (inputField != null)
        {
            inputField.DeactivateInputField();
        }
    }
}
