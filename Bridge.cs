using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bridge : MonoBehaviour
{
    public TMP_Text DisplayMessage;
    public TMP_InputField messageField;
    public Button sendbtn;

    [Obsolete]
    private void Start()
    {
        sendbtn.onClick.AddListener(SendM);
    }


    [Obsolete]
    public void SendM()
    {
        string messageFieldText = messageField.text;
        Application.ExternalCall("sendMessage", messageFieldText);
    }

    public void ReveiveM(string Message)
    {
        DisplayMessage.text = Message;
    }
}
