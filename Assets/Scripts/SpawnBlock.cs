using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour {

	public GameObject wall;
	public float x;
	public float z;
	bool spawned = false;
	GameObject spawnedWall;

	void Start()
	{
		spawnedWall = null;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && spawned == false)
		{
			spawned = true;
			spawnedWall = (GameObject)Instantiate(wall, new Vector3(x, 1, z), Quaternion.identity);

		}
		else if (other.tag == "Player" && spawned)
		{
			spawned = false;
			Destroy(spawnedWall);

		}
	}
}
