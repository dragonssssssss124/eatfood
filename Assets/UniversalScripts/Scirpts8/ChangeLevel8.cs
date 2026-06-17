using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeLevel8 : MonoBehaviour
{
    public TMP_Text myText;

    void Update()
    {
        int value;

        // Try converting text into a number
        if (int.TryParse(myText.text, out value))
        {
            if (value == 250)
            {
                SceneManager.LoadScene(9);
            }
        }
    }
}
