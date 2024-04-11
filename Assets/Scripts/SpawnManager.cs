using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;

    float minY = -1.0f;
    float maxY = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2, 1);
    }                      //what, when, how often

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(4.5f,Random.Range(minY,maxY)), Quaternion.identity);
    }
}
