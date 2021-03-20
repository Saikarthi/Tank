using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public GameObject g;
    private Vector3 v;
    public Vector3 s;
   

    void Start()
    {
        
    }

    void Update()

    {

        v = g.transform.position;
      

        this.transform.position = v+s;
    }
}
 