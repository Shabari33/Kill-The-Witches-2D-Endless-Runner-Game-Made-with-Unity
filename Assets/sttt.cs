using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sttt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void quit()
    {
        Application.Quit();
    }
    public void play()
    {
        SceneManager.LoadScene("attack1");
    }
    public void controls()
    {
        SceneManager.LoadScene("controls");
    }
    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
