using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float health;
    public bool v;
    private swapgameobject s;
    private score sco;
    // Start is called before the first frame update
    void Start()
    {
        s = this.gameObject.GetComponent<swapgameobject>();
        sco = GameObject.FindWithTag("score").GetComponent<score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void takedamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {

            die();

            sco.addpoint = true;
       
            //h.score += 1;

            // ex.Play();
            // Invoke("die", 0.5f);
        }
    }
    public void die()
    {
        v = true;
    }
}
