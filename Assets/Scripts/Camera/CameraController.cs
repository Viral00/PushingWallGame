using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 offSet;
    [SerializeField] private PlayerView playerPrefab;

    private void Update()
    {
        transform.position = playerPrefab.transform.position + offSet;
    }
}
