using UnityEngine;
using System.Collections;

public class MenuBall : MonoBehaviour
{
    public int ball_velocity = 100;
    public Rigidbody rb;

    void Awake()
    {
        rb.velocity = new Vector3(ball_velocity, ball_velocity, 0);
    }
}
