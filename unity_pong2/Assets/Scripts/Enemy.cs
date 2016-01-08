using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed = 8;
    Vector3 target_position;
    Vector3 player_position;
    GameObject ball_object;
	
	void Update ()
    {
        ball_object = GameObject.FindGameObjectWithTag("Ball");
        if(ball_object != null)
        {
            target_position = Vector3.Lerp(gameObject.transform.position, ball_object.transform.position, Time.deltaTime * speed);
            player_position = new Vector3(-20, Mathf.Clamp(target_position.y, -12.5F, 12.5F), 0);
            gameObject.transform.position = new Vector3(20, player_position.y, 0);
        }
	}
}
