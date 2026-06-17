using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour
{
    public GameObject tongue;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            tongue.SetActive(true);
        }

        if (Input.GetKeyUp("space"))
        {
            tongue.SetActive(false);
        }
    }
}
