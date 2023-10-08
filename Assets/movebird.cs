using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebird : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //(-1,0,0) 
    }
}
