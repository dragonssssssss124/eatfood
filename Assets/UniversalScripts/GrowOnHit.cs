using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowOnHit : MonoBehaviour
{
        public Transform player;

    public Vector3 bigSize = new Vector3(2f, 2f, 2f);
    public float growTime = 3f;

    Vector3 normalSize;
    bool used = false;

    void Start()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Frog").transform;

        normalSize = player.localScale;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (used) return;

        if (other.CompareTag("Frog"))
        {
            used = true;

            player.localScale = bigSize;

            player.position = new Vector3(0f, 1.5f, 0f);

            StartCoroutine(GrowThenShrink());
        }
    }

    IEnumerator GrowThenShrink()
    {
        // hide powerup immediately
        GetComponent<Collider2D>().enabled = false;
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null) sr.enabled = false;

        yield return new WaitForSeconds(growTime);

        player.localScale = normalSize;

        player.position = new Vector3(0f, -2f, 0f);

        Destroy(gameObject);
    }


}
