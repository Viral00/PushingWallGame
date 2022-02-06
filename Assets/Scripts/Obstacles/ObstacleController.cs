using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleController : MonoBehaviour
{
    private int obstacleHealth;
    private int currentHealth;
    public ObstacleHealth obstacle_health;

    private void Awake()
    {
        obstacleHealth = Random.Range(5, 30);
    }
    private void Start()
    {
        currentHealth = obstacleHealth;
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(this);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            TakeDamage(1);
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        obstacle_health.SetObstacleHealth(currentHealth);
    }
}
