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
        obstacle_health.SetObstacleHealth(currentHealth);
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
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
