using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Best Score: " + Score.bestscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
