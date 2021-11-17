using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
	[HideInInspector]
	public GameObject bulletPrefab;
	[HideInInspector]
	public Transform gunMuzzleTransform;
	private Vector3 playerPosition;
	private Quaternion playerRotation;
	public Transform startPosition;
	public Object bullet;
	private Transform bulletRef;
	[HideInInspector]
	public AudioManager audioManager;
	
	void Awake ()
	{
		bulletRef = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Transform>();
		transform.position = startPosition.position;
		transform.rotation = startPosition.rotation;
		playerPosition = transform.position;
		playerRotation = transform.rotation;
		audioManager = GameObject.FindObjectOfType<AudioManager> ();
	}

	void Start()
	{
		
	}

	void Update()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			if(bullet != null)
			{
				Instantiate(bullet, bulletRef.transform.position, bulletRef.transform.rotation);
				audioManager.PlayerShoot ();
			}
		}
	}
	
    public void RespawnRoutine(float waitTime)
    {
        Invoke("Respawn", waitTime);
        RenderSettings.fogDensity = 0.2f;
        Time.timeScale = 0.1f;
    }

    public void Respawn()
    {
        Time.timeScale = 1.0f;
        RenderSettings.fogDensity = 0.001f;
        transform.position = playerPosition;
        transform.rotation = playerRotation;
        audioManager.PlayerSpawned();
    }

	public void Death ()
	{
        audioManager.PlayerDied();
	}
	

	public void Checkpoint (GameObject instance)
	{
		playerPosition = transform.position;
		playerRotation = transform.rotation;
		audioManager.CheckpointTaken (instance);
	}
	
	void OnHit()
	{
		Death();
	}
	

}
