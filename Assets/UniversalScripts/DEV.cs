using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEV : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            SceneManager.LoadScene(2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            SceneManager.LoadScene(3);
        }
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene(4);
        }
        if (Input.GetKey(KeyCode.G))
        {
            SceneManager.LoadScene(5);
        }
        if (Input.GetKey(KeyCode.H))
        {
            SceneManager.LoadScene(6);
        }
        if (Input.GetKey(KeyCode.J))
        {
            SceneManager.LoadScene(7);
        }
        if (Input.GetKey(KeyCode.K))
        {
            SceneManager.LoadScene(8);
        }
    }
  
}
