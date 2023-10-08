using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(3,Random.Range(-4.2f,-8.5f),0);
            timer = 0;    
            Destroy(newpipe,7.0f);
        }
        
    }
}
