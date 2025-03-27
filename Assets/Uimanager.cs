using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.SocialPlatforms.Impl;

public class Uimanager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoretext;
    public float score=0;
    public float speed = 0.2f;
    public static Uimanager instance ;
    public TextMeshProUGUI final;
    public TextMeshProUGUI kills;
    public int k;
    public TextMeshProUGUI killscore;
    private void Awake()
    {
        instance= this;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        buu2();
    }
    public void buuu()
    {
        SceneManager.LoadScene("twoscene");
        Time.timeScale = 1f;

    }
    public void buu2()
    {
        score = score + Time.deltaTime * speed;
        scoretext.text = (int)score + "m";
    }
    public void iss()
    {
        final.text = "your score : " + scoretext.text.ToString();
    }
    public void off(int sc)
    {
        k += sc;
        kills.text = "Kills : " + k.ToString();
    }
    public void ki()
    {
        killscore.text = " Witches destroyed : " +k.ToString();
    }
   
}
