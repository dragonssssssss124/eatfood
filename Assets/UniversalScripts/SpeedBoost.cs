using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float speedBoostAmount = 5f;
    public float boostTime = 7f;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Checks if the player touched the object
        if (collision.CompareTag("Frog"))
        {
            PlayerMovement2D player = collision.GetComponent<PlayerMovement2D>();

            if (player != null)
            {
                StartCoroutine(GiveSpeedBoost(player));
            }
           
            // Removes the powerup object
            
        }
    }

    IEnumerator GiveSpeedBoost(PlayerMovement2D player)
    {
        // Adds speed
        player.moveSpeed += speedBoostAmount;

        // Waits 7 seconds
        yield return new WaitForSeconds(boostTime);

        // Removes extra speed
        player.moveSpeed -= speedBoostAmount;

        
    }
}
