using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resumeandquit : MonoBehaviour
{
    public GameObject pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resume()
    {
        Time.timeScale = 1;
        pausemenu.SetActive(false); 
    }
    public void qtt()
    {
        Application.Quit(); 
    }
}
