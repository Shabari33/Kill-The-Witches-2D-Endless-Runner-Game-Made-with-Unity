using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
   public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            Destroy(this.gameObject);
         

        }
        if (collision.gameObject.tag == "Player")
        {  
            Destroy(this.gameObject);   
            Destroy(collision.gameObject);
        

           
        }
    }
       
}
