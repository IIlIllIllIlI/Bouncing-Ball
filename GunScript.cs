using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float rotationSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gunRotate();
        

    }

    private void gunRotate()
    {
        Vector3 currentEulerAngles = transform.eulerAngles;
        if ((currentEulerAngles.z < 55 || currentEulerAngles.z > 180)
            && Input.GetKey(KeyCode.A))
        {
            currentEulerAngles += new Vector3(0, 0, rotationSpeed * Time.deltaTime);
        }
        else if ((currentEulerAngles.z < 180 || currentEulerAngles.z > 305)
            && Input.GetKey(KeyCode.D))
        {
            currentEulerAngles -= new Vector3(0, 0, rotationSpeed * Time.deltaTime);
        }

        transform.eulerAngles = currentEulerAngles;
    }
}
