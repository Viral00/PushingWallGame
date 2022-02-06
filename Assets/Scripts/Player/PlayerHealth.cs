using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthBar healthBar;
    private int maxHealth = 50;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetPlayerMaxhealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            TakeDamage(1);
        }
        else if (collision.gameObject.tag == "PickUp")
        {
            if (currentHealth <= 50)
            {
                GainHealth(8);
            }
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetPlayerHealth(currentHealth);
    }

    private void GainHealth(int health)
    {
        currentHealth += health;
        healthBar.SetPlayerHealth(currentHealth);
    }
}
