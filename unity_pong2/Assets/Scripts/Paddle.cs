using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
    public float paddle_speed = 1;
    public Vector3 player_position;

    void Update()
    {
        float y_position = transform.position.y + (Input.GetAxis("Vertical") * paddle_speed);
        player_position = new Vector3(-20, Mathf.Clamp(y_position, -12.5F, 12.5F), 0);
        gameObject.transform.position = player_position;
    }

}
