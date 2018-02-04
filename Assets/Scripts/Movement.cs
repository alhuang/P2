using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 10f;
	Vector3 pos;
	Transform tr;
	bool[] raycasts;

	// Use this for initialization
	void Start () {
		tr = transform;
		pos = transform.position;
		raycasts = new bool[4];
	}
	
	// Update is called once per frame
	void Update () {
		raycasts[0] = Physics.Raycast(pos, Vector3.left, 0.6f); //left
		raycasts[1] = Physics.Raycast(pos, Vector3.forward, 0.6f); //up
		raycasts[2] = Physics.Raycast(pos, Vector3.right, 0.6f); // right
		raycasts[3] = Physics.Raycast(pos, Vector3.back, 0.6f); //down

		if (tr.position.y == 1)
		{
			if (Input.GetKey(KeyCode.RightArrow) && tr.position == pos)
			{
				if (!raycasts[2])
					pos += Vector3.right;
			}
			else if (Input.GetKey(KeyCode.LeftArrow) && tr.position == pos)
			{
				if (!raycasts[0])
					pos += Vector3.left;
			}
			else if (Input.GetKey(KeyCode.UpArrow) && tr.position == pos)
			{
				if (!raycasts[1])
					pos += Vector3.forward;
			}
			else if (Input.GetKey(KeyCode.DownArrow) && tr.position == pos)
			{
				if (!raycasts[3])
					pos += Vector3.back;
			}

			transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
		}

	}

}
