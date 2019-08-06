using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMessage : MonoBehaviour
{
    Text text;
    int current = 1;

    void Start()
    {
        text = GetComponentInChildren<Text>();
    }

    public void ShowText()
    {
        var m = new Message
        {
            Text = "Hello",
            Version = "1.0.3",
        };
        text.text = m.GetMessage() + $" ({current++})";
    }
}
