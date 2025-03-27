using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawmb : MonoBehaviour

{
    AudioSource audioSource;
    public GameObject laser;
    public AudioClip eff;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        bullet();
    }
    void bullet()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(laser);
            audioSource.PlayOneShot(eff);

        }
    }
   
}
    