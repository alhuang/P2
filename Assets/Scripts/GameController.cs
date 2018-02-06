using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public GameObject finish1;
	public GameObject finish2;
	public GameObject text;

	// Use this for initialization
	void Start () {
		text.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (player1.transform.position.y < -10 || player2.transform.position.y < -10)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

		}

		if (finish1.GetComponent<FinishBlock>().finish && finish2.GetComponent<FinishBlock>().finish)
		{
			text.SetActive(true);
			if (Input.GetKey(KeyCode.Space)) {
				int curSceneIndex = SceneManager.GetActiveScene().buildIndex;
				Debug.Log(curSceneIndex.ToString());
				if (curSceneIndex + 1 < SceneManager.sceneCountInBuildSettings)
					SceneManager.LoadScene(curSceneIndex + 1);
				else
					SceneManager.LoadScene(0);
				Debug.Log("Win!");
			}
		}
	}
}
