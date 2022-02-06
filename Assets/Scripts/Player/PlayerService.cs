using UnityEngine;

public class PlayerService : MonoSingleton<PlayerService> 
{
    public PlayerView playerPrefab;

    private void Start()
    {
        PlayerModel playerModel = new PlayerModel(700f, 1500f);
        PlayerController playerController = new PlayerController(playerModel, playerPrefab);
    }
}
