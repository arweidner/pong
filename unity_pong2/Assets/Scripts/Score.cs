using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public TextMesh current_score;
    public GameObject ball_prefab;
    public Transform paddle_object;

    GameObject ball;
    int score;
	
	void Update ()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        current_score.text = "" + score;
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            score += 1;
            Destroy(ball);
            (Instantiate(ball_prefab, new Vector3(paddle_object.transform.position.x + 2, paddle_object.transform.position.y, 0),Quaternion.identity) as GameObject).transform.parent = paddle_object;
        }
    }
}
