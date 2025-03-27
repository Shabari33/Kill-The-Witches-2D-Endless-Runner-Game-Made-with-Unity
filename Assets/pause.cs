using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
   
{
    public GameObject pausepannel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            pausebutton();
        }

    }
 public   void pausebutton()
    {
        pausepannel.SetActive(true);   
        Time.timeScale = 0f;
    }

}
