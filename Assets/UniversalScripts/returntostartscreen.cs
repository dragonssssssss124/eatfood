using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returntostartscreen : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene(0);
    }
}
