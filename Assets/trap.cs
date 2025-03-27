using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class trap : MonoBehaviour

{
    public GameObject trapPrefab;
    public TextMeshProUGUI scoretext;
    public int score = 0;
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
            score += 1;
            scoretext.text = score.ToString();

        }
    }
}
