using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float paddle_speed = 1;
	public Vector3 player_pos;
	
	// Update is called once per frame
	void Update () 
	{
		float y_pos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * paddle_speed);
		player_pos = new Vector3 (-20, Mathf.Clamp(-11, 11), 0);
        gameObject.transform.position = player_pos;
	}
}
