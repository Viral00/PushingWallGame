using UnityEngine;

public class PlayerModel 
{
    public PlayerModel(float forwardspeed, float sidewayspeed)
    {
        forwardSpeed = forwardspeed;
        sideWayspeed = sidewayspeed;
    }

    public float forwardSpeed { get; }
    public float sideWayspeed { get; }
}
