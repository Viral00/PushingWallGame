using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerController player_controller;
    private Rigidbody rb;

    public PlayerView(PlayerController playercontroller)
    {
        playerController = playercontroller;
    }

    public PlayerController playerController { get; }

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        player_controller.PlayerConstantForce(rb);
        
        player_controller.PlayerSideMovement(rb);
    }
}
