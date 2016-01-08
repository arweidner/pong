using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    int randX;
    int randY;
    public GameObject ball;

	void Start ()
    {
        Spawn();
	}
	
	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            Spawn();
        }
	}

    void CreateRandomPosition()
    {
        randX = Random.Range(-7, 7);
        randY = Random.Range(-3, 3);
    }

    void Spawn()
    {
        CreateRandomPosition();

        Instantiate(ball, new Vector3(randX, randY, 0), Quaternion.identity);
    }
}
