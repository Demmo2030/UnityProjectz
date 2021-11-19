using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public float deathWaitTime = 3.0f;
    public bool showTimeofdayDebug = false;
    public bool showMovementDebug = false;

    public AudioPlayerActions audioPlayerActions;

    private void Awake()
    {
        GameStart();
        //Makes mouse cursor invisible when playing
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Runs once when the scene loads
    public void GameStart()
    {
        Debug.Log("GameStart");
        PlayerSpawned();
    }

    //Runs everytime the player spawns
    public void PlayerSpawned ()
	{
        Debug.Log("PlayerSpawned");
	}

    //Prints the name of the current Game Object the player steps on
	public void PlayerFootstep(Transform obj)
	{
        audioPlayerActions.AudioPlayerStep();
        if (showMovementDebug)
            Debug.Log("PlayerFootstep on object: " + obj.name);
	}

    //Prints the name of the current Game Object the player jumps from
    public void PlayerJump(Transform obj)
	{
        if (showMovementDebug)
            Debug.Log("PlayerJump on object: " + obj.name);
    }

    //Prints the name of the current Game Object the player lands on
    public void PlayerLand(Transform obj)
	{
        if (showMovementDebug)
            Debug.Log("PlayerLand on object: " + obj.name);
    }

	public void PlayerShoot ()
	{
        Debug.Log("PlayerShoot");
    }

	public void PlayerDied ()
	{
        Debug.Log("PlayerDied");
        FindObjectOfType<Player>().RespawnRoutine(deathWaitTime / 10);
    }

	public void CheckpointTaken (GameObject instance)
	{
        Debug.Log("CheckpointTaken: " + instance.name);
	}

	public void PickupTaken (GameObject instance)
	{
        Debug.Log("PickupTaken: " + instance.name);
    }

	public void MovingNPCSpawned()
	{
        Debug.Log("MovingNPCSpawned");
	}

    //When player hits Moving NPC with a bullet
	public void MovingNPCHit(int hitpoints)
	{
        Debug.Log("MovingNPC Hitpoints left: " + hitpoints);
	}

	public void MovingNPCKilledplayer()
	{
        Debug.Log("MovingNPCKilledplayer");
	}

	public void MovingNPCDied()
	{
        Debug.Log("MovingNPCDie");
	}

    //Runs when player enters Sentrygun/Sensor's trigger
	public void StationaryNPCActivated(GameObject instance)
	{
        Debug.Log("StationaryNPCActivated: " + instance.name);
    }

    //Runs when player exits Sentrygun/Sensor's trigger
    public void StationaryNPCDeactivated()
	{
        Debug.Log("StationaryNPCDeactivated");

    }

	public void StationaryNPCShoot()
	{
        Debug.Log("StationaryNPCShoot");
    }

	public void StationaryNPCRotationStarted()
	{
        Debug.Log("StationaryNPCRotationStarted");
    }

	public void StationaryNPCRotationStopped()
	{
        Debug.Log("StationaryNPCRotationStopped");
    }

	public void StationaryNPCDied()
	{
        Debug.Log("StationaryNPCDied");
    }

	public void EventATriggered()
	{
        Debug.Log("EventATriggered");
    }

	public void EventBTriggered()
	{
        Debug.Log("EventBTriggered");
    }

	public void PlayerWon(float waitTime)
	{
        Debug.Log("PlayerWon - waiting: " + waitTime + "seconds");
	}

    //Receives the current value of TimeOfDay once every frame
	public void Timeofday(float timeofday)
	{
        if(showTimeofdayDebug)
            Debug.Log("TimeOfDay is: " + timeofday);
	}
}