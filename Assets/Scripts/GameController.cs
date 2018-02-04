using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public GameObject finish1;
	public GameObject finish2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player1.transform.position.y < -10 || player2.transform.position.y < -10)
		{
			SceneManager.LoadScene("main");

		}

		if (finish1.GetComponent<FinishBlock>().finish && finish2.GetComponent<FinishBlock>().finish)
		{
			Debug.Log("Win!");
		}
	}
}
