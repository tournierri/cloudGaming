using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealth.instance.Die();
            GameOverManager.instance.OnPlayerDeath();
        }
    }
}
