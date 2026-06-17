using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float move = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            move = -2f; // left
        }
        if (Input.GetKey(KeyCode.D))
        {
            move = 2f; // right
        }
        if (Input.GetMouseButton(0))
        {
            move = -4f;
        }
        if (Input.GetMouseButton(1))
        {
            move = 4f;
        }

        Vector3 movement = new Vector3(move, 0f, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}