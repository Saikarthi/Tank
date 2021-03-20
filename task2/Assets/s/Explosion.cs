using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    private float minf=100f, maxf=150f, r=5f;
   

    private void Start()
    {
        explosion();
    }
    public void explosion()
    {
        foreach(Transform t in transform)
        {
         
            var rb = t.gameObject.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(Random.Range(minf, maxf), transform.position, r);
            }
            float a = Random.Range(0.5f, 1f);
            Destroy(t.gameObject, a);
          
            
        }
    }
}
