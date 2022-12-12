using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    [SerializeField] AudioClip coinSFX;
    [SerializeField] int pointsForCoinPickups = 10;

    bool wasCollected = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && !wasCollected)
        {
            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickups);
            AudioSource.PlayClipAtPoint(coinSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
