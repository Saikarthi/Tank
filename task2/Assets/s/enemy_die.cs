using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class enemy_die : MonoBehaviour
{

    private target t;
    public TextMeshProUGUI text_health;
    public int health ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text_health.SetText(health.ToString());
    }


     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
           
            t=collision.gameObject.GetComponent<target>();
            t.v = true;
            if(this.gameObject.name== "player")
            {
                health -= 25;
            }

            Destroy(collision.gameObject,0.5f);
        }
    }
}
