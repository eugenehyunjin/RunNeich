using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NeichJump : MonoBehaviour
{
    Rigidbody2D rb;
    //Transform t;
     //public float fixedRotation = 0;    
     public float jumpPower;
     public float lockPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
         //t = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //t.eulerAngles = new Vector3 (t.eulerAngles.x, fixedRotation, t.eulerAngles.z);
        transform. rotation = Quaternion. Euler(transform. rotation. eulerAngles. x, lockPos, lockPos);
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0,1)
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }
        if (collision.collider.name.ToString() == "Pipe" || collision.collider.name.ToString() == "Pipe(Clone)")
        {
            SceneManager.LoadScene("GameOverScene");
        }
        if (collision.collider.name.ToString() == "Bird" || collision.collider.name.ToString() == "Bird(Clone)")
        {
            SceneManager.LoadScene("GameOverScene");
        }
         if (collision.collider.name.ToString() == "Wall" || collision.collider.name.ToString() == "Sky")
        {
            SceneManager.LoadScene("GameOverScene");
        }
        
    }
}
