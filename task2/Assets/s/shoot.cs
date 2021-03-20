using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float speed, firerate;
    public GameObject hitpoint;
  private target Target;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed != 0)
        {
            this.transform.position += transform.forward * (speed * Time.deltaTime);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            speed = 0f;
            ContactPoint c = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, c.normal);
            Vector3 pos = c.point;
            var vfx = Instantiate(hitpoint, pos, rot);
            Destroy(vfx, 2f);
            Destroy(gameObject);
            if (collision.gameObject.tag == "enemy")
            {
                Target = collision.transform.GetComponent<target>();
            }
            if (Target != null)
            {
                Target.takedamage(damage);
            }
        }
    }
}
