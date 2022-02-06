using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObstacleHealth : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMesh;

    public void SetObstacleHealth(int health)
    {
        textMesh.text = "" + health;
    }
}
