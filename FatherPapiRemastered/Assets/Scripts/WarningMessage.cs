using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarningMessage : MonoBehaviour
{
    private Text warningText;
    public string message = "Danger: Falling Objects!";

    private void Start()
    {
        warningText = GetComponent<Text>();
    }

    public void StartWarning()
    {
        warningText.enabled = true;
        warningText.text = message;
    }

    public void StopWarning()
    {
        warningText.enabled = false;
    }
}
