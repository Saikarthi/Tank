using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{

    public GameObject broken;//The Broken Object
    public float minf, maxf, r;
    void OnCollisionEnter (Collision col)//When Object Collides
    {
        Shatter();
    }
    void Shatter()
    {
        Instantiate(broken,transform.position, transform.rotation);//Instantiate The Broken Version Of The Object At The Current Position 
        Destroy(this.gameObject);//And Delete the Current GameObject
        explosion();
    }
    public void explosion()
    {
        foreach (Transform t in transform)
        {
            var rb = t.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(Random.Range(minf, maxf), transform.position, r);
            }
        }
    }
}
