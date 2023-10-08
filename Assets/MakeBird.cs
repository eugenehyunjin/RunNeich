using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBird : MonoBehaviour
{
    public GameObject bird;
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
            GetComponent<AudioSource>().Play();
            GameObject newbird = Instantiate(bird);
            newbird.transform.position = new Vector3(6,Random.Range(1f,4.5f),0);
            timer = 0;    
            Destroy(newbird,6.0f);
        }
        
    }
}
