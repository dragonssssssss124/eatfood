using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eating : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FLY"))
        {
            ScoreManager.instance.AddScore(1);
            Destroy(collision.gameObject);
        }
    }
}
