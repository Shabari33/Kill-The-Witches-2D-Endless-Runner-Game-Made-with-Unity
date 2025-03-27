using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Renderer bgrender;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgrender.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
        
    }
}
