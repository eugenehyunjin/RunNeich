using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score > 10)
        {
             transform.position += Vector3.left * 3 * Time.deltaTime; //(-1,0,0) 
        }
        transform.position += Vector3.left * speed * Time.deltaTime; //(-1,0,0) 
    }
}
