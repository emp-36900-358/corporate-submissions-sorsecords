using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class callsofkeyboad : MonoBehaviour
{
    public InputField inputField;

    public void ShowKeyboard()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false);
        TouchScreenKeyboard.hideInput = false;
    }

    public void HideKeyboard()
    {
        TouchScreenKeyboard.hideInput = true;
    }

    private void Start()
    {
        inputField.Select();
        inputField.onEndEdit.AddListener(delegate { HideKeyboard(); });
    }
}