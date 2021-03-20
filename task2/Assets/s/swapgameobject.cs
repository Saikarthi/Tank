using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapgameobject : MonoBehaviour
{
    public GameObject change,partical;
    private GameObject nonchange;
   
    public Vector3 offset;

    private target t;

  

    public void Start()
    {
        t = this.gameObject.GetComponent<target>();
        

        nonchange = this.gameObject;
    }
    private void Update()
    {
        swap();
    }
    public void  swap()
    {
        
        if (t.v )
        {
            
            GameObject fx = Instantiate(partical, nonchange.transform.position + offset, nonchange.transform.rotation) as GameObject;
            Destroy(fx, 5f);

            GameObject f = Instantiate(change,nonchange.transform.position, nonchange.transform.rotation);
            Destroy(nonchange);
            f.gameObject.GetComponent<Explosion>().explosion();
            Destroy(f,2);
            t.v = false;
            
        }
    }
}
