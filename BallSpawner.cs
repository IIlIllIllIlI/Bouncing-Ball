using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    private float timer = 1;
    private float spawnRate = 0.5f;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space))
            {
                GameObject dBall;
                dBall = Instantiate(ball, transform.position, transform.rotation);
                timer = 0;

                dBall.GetComponent<BallScript>().fire();
            }
        }
    }
}
