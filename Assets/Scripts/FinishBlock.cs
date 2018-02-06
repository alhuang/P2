using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBlock : MonoBehaviour {

	public bool finish = false;

	void OnTriggerStay(Collider other)
	{
		Debug.Log("ontrigger");
		if (other.tag == "Player")
		{
			finish = true;
		}
	}

	void OnTriggerExit(Collider other)
	{

		if (other.tag == "Player")
		{
			finish = false;
		}
	}
}
