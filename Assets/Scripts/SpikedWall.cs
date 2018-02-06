using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikedWall : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("Ouch! Gameover!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
