using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject PickUpObject;
    [SerializeField] private Transform spawnPoint;
    private List<GameObject> PickUpPool = new List<GameObject>();
    private int amountToPool = 10;

    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject pickUpObj = Instantiate(PickUpObject, spawnPoint.position, Quaternion.identity);
            pickUpObj.SetActive(false);
            PickUpPool.Add(pickUpObj);
        }

    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < PickUpPool.Count; i++)
        {
            if (!PickUpPool[i].activeInHierarchy)
            {
                return PickUpPool[i];
            }
        }

        return null;
    }
}
