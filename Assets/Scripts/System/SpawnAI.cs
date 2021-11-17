using UnityEngine;
using System.Collections;

public class SpawnAI : MonoBehaviour
{
	public Object runner;
	
	void Awake()
	{
		if (runner == null)
		{
			return;
		}
	}

	public void Spawn(Transform spawnTrans)
	{
		Instantiate(runner, spawnTrans.localPosition, spawnTrans.localRotation);
	}



}
