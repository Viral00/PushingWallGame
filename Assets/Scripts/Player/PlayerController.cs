using UnityEngine;

public class PlayerController 
{
    public PlayerController(PlayerModel playermodel, PlayerView playerprefab )
    {
        playerModel = playermodel;
        playerPrefab = playerprefab;
        playerPrefab.player_controller = this;
    }

    public PlayerModel playerModel { get; }
    public PlayerView playerPrefab { get; }

    public void PlayerSideMovement(Rigidbody rb)
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(playerModel.sideWayspeed*Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-playerModel.sideWayspeed * Time.deltaTime, 0, 0);
        }
    }

    public void PlayerConstantForce(Rigidbody rb)
    {
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, playerModel.forwardSpeed* 2 * Time.deltaTime);
        }
        else
        {
            rb.AddForce(0, 0, playerModel.forwardSpeed * Time.deltaTime);
        }
        
    }
}
