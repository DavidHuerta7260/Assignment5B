/*
* David Huerta
* 3D Prototype
* Handles target health and destruction when taking damage.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Add to score before destroying
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.AddPoint();
        }

        Destroy(gameObject);
    }
}
