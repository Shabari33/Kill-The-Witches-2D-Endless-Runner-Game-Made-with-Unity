using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapspawn : MonoBehaviour
{
    public GameObject trap;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            Vector3 pos = new Vector3(Random.Range(2.6f, 5.3f), -5.203f, 0);
            Instantiate(trap, pos, Quaternion.identity);

        }
    }
}
