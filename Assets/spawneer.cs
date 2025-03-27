using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawneer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject witch;
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
            yield return new WaitForSeconds(Random.Range(2f,5f));
            Vector3 pos = new Vector3(Random.Range(3.83f, 5.51f), -1.64f, 0);
            Instantiate(witch, pos, Quaternion.identity);
        }
    }
}