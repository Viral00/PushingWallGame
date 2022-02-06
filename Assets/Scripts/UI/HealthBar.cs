using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    public void SetPlayerMaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetPlayerHealth(int health)
    {
        slider.value = health;
    }
}
