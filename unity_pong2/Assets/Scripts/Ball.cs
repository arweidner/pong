using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public float ball_velocity = 3000;

    Rigidbody rb;
    bool is_play;   // False by default
    int rand_int;

	void Awake ()
    {
        rb = gameObject.GetComponent<Rigidbody> ();
        rand_int = Random.Range(1, 2);
	}
	
	void Update ()
    {
	    if(Input.GetMouseButton(0) == true && is_play == false)
        {
            transform.parent = null;
            is_play = true;
            rb.isKinematic = false;

            if(rand_int == 1)
            {
                rb.AddForce(new Vector3(ball_velocity, ball_velocity, 0));
            }

            if(rand_int == 2)
            {
                rb.AddForce(new Vector3(-ball_velocity, -ball_velocity, 0));
            }
        }
	}
}
