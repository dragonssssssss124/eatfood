using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeLevel2 : MonoBehaviour
{
    public TMP_Text myText;

    void Update()
    {
        int value;

        // Try converting text into a number
        if (int.TryParse(myText.text, out value))
        {
            if (value == 100)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
