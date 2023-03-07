using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float initialSpeed = 30;
    public Rigidbody2D myRigidBody;
    // public GameObject gun;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        fire();
        //myRigidBody.velocity = new Vector3(0, 1, 0) * initialSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void fire()
    {

        //float angle = GameObject.FindGameObjectWithTag("Gun")
        //    .transform.rotation.eulerAngles.z;
        //Debug.Log(angle);
        //Vector3 direction;
        //if (angle == 0)
        //{
        //    direction = new Vector3(0, 1, 0);
        //}
        //else
        //{
        //    if (angle > 180)
        //    {
        //        direction = new Vector3(angle, angle, 0).normalized;
        //    } else
        //    {
        //        direction = new Vector3(-angle, angle, 0).normalized;
        //    }

        //}
        Vector3 direction = GameObject.FindGameObjectWithTag("Gun").transform.up;
        Debug.Log(direction);
        myRigidBody.velocity = direction * initialSpeed * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addCount();
        }
    }

}
