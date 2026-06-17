using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minusscore : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FOOD"))
        {
            ScoreManager.instance.MinusScore(1);
            Destroy(collision.gameObject);
        }
    }
}
