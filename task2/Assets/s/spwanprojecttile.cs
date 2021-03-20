using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanprojecttile : MonoBehaviour
{
    public GameObject firepoint;
    public List<GameObject> vfx;
    private GameObject effecttoswpan;
    public movement m;

    private float timetofire = 0f;
    public ParticleSystem p;
    public GameObject fps;
    public float range;
    private int shoot=0;



    void Start()
    {
        effecttoswpan = vfx[0];
    }

    // Update is called once per frame
    void Update()
    {
        ray();
        if (shoot == 1 && Time.time >= timetofire)
        {
           
            timetofire = Time.time + 1 / effecttoswpan.GetComponent<shoot>().firerate;
            sp();
            shoot = 0;
        }
    }
 
    public void sp()
    {
      
        GameObject vfxa;
        if(firepoint != null)
        {
            vfxa = Instantiate(effecttoswpan, firepoint.transform.position, firepoint.transform.rotation);
            p.Play();
            Destroy(vfxa, 6f);
        }
        else
        {
            Debug.Log("error");
        }
    }
    public void ray()
    {
        RaycastHit hit;
        if (Physics.Raycast(fps.transform.position, fps.transform.forward, out hit, range))
        {
            if(hit.transform.tag == "enemy")
            shoot = 1;
        }
        else
        {
            shoot = 0;
        }
    }
}
