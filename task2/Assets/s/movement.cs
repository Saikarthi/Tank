using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;



public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float rspeed;
    public float h;
 

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per fram
     void FixedUpdate()
     {
        //float haxis = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
        float vaxis = CrossPlatformInputManager.GetAxis("Vertical") * speed;
       // this.transform.position += new Vector3(haxis,0,vaxis);
        this.transform.position += transform.forward * vaxis;
       


        //rotation
        if (vaxis != 0)
        {
            h = CrossPlatformInputManager.GetAxis("h") * rspeed;

        }

     


        this.transform.Rotate(new Vector3(0, h, 0));
        //firepoint rotation
       // g.transform.Rotate(new Vector3(0, h, 0));
    }
}
