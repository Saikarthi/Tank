using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spwaning : MonoBehaviour
{
    public GameObject g;
    public float end;
    private new float tag =0;
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            On();
        }
    }

    void Update()
    {
        tag = GameObject.FindGameObjectsWithTag("enemy").Length;
      

        if(tag<=end)
        {
            On();
           
        }
        else
        {
           
        }
           
      
        
    }

    private void On()
    {
        bool spwan = false;
        while(!spwan)
        {
            Vector3 player_pos = new Vector3(this.transform.position.x+Random.Range(-25f, 25f),0.1f, this.transform.position.y + Random.Range(-25f, 25f));
                if ((player_pos - transform.position).magnitude < 10) 
                        continue;
                else
                {
                     if ((player_pos.x >= -130f && player_pos.x <= 100f) && (player_pos.y >= -123f && player_pos.y <= 121f))
                     {
                             Instantiate(g, player_pos,Quaternion.identity);
                             spwan = true;
                     }
               
                }
        }
    }
}
