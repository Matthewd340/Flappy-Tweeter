using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    BirdController birdScript;

    float minY = -1.0f;
    float maxY = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2, 1);
                            //what, when, how often
        birdScript = GameObject.Find("Red_Bird_0").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
     if(birdScript.isAlive == false)
     {
        CancelInvoke();
     }   
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(4.5f,Random.Range(minY,maxY)), Quaternion.identity);
    }
}
