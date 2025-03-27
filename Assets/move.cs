using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class move : MonoBehaviour
{
    public int movespeed;
    public  int kills=0;
    public static move instance;

    // Start is called before the first frame update
    public void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*movespeed*Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "witch")
        {
            kills++;
            Uimanager.instance.off(kills);
        }
    }
    public void kkk()
    {
        
    }
}

