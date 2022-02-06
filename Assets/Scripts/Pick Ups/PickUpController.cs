using UnityEngine;

public class PickUpController : MonoBehaviour
{
    [SerializeField] private ObjectPool PickUpPool;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            gameObject.SetActive(false);
        }
    }
}
