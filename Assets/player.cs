using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using JetBrains.Annotations;
using UnityEngine.UIElements;

public class player : MonoBehaviour

{
    // Start is called before the f
    // irst frame update
    public Rigidbody2D rb;
    public float jumpforce = 5f;
    public Animator animator;
    public bool isground = false;
    AudioSource audiosource;
    public AudioClip jumpaudio; 
    public AudioClip downclip;
    public GameObject pannel;
    public TextMeshProUGUI text;
    public AudioClip gameover;
    public GameObject gameobj;
    public static player instance;
    public GameObject pausepannel;
    private void Awake()
    {
        instance = this; }
    
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        audiosource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isground = true;
            animator.SetBool("isJump", false);
            animator.SetBool("isRun", true);
            audiosource.PlayOneShot(downclip);

        }
        if (collision.gameObject.tag == "witch")
        {
            Uimanager.instance.ki();
            Uimanager.instance.iss();
            
            gameobj.SetActive(false);
            Destroy(this.gameObject);
            pannel.SetActive(true);
            pausepannel.SetActive(false);
            Time.timeScale = 0;
            audiosource.PlayOneShot(gameover);
          





        }
        if (collision.gameObject.tag == "trap")
        {  Uimanager.instance.ki();
            Uimanager.instance.iss();
            pannel.SetActive(true);
            pausepannel.SetActive(false);
            gameobj.SetActive(false);
            Destroy(this.gameObject);
            Time .timeScale = 0;
            audiosource.PlayOneShot(gameover);


        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
           
            isground = false;
            animator.SetBool("isRun", false);
            animator.SetBool("isJump", true);
        }
    }
    public void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isground == true)
        {
            animator.SetBool("isRun", false);
            rb.velocity = new Vector3(rb.velocity.x, jumpforce, 0f);
            animator.SetBool("isJump", true);
            audiosource.PlayOneShot(jumpaudio);




        }
    


    
    }
    public void ttt()
    {
        pannel.SetActive (true);
    }


}

