using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nocheating2 : MonoBehaviour
{
    public float holdTime = 0.5f;
    private float timer = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            timer += Time.deltaTime;

            if (timer >= holdTime)
            {
                ResetLevel();
                SceneManager.LoadScene(10);
            }
        }
        else
        {
            timer = 0f;
        }
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(10);
    }
}
