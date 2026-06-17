using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public TMP_Text myText;

    void Update()
    {
        int value;

        // Try converting text into a number
        if (int.TryParse(myText.text, out value))
        {
            if (value == 50)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}


