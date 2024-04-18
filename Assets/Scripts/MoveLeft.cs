using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveLeft : MonoBehaviour
{
    public float speed = 1.0f;
    BirdController birdScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the pipes left
       
        if(birdScript.isAlive == true)
     {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        CancelInvoke();
     }   
    }

    void Awake ()
    {
        birdScript = GameObject.Find("Red_Bird_0").GetComponent<BirdController>();
    }
}
