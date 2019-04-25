using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
    void Awake()
    { 
}

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Rigidbody2D rb = col.GetComponent<Rigidbody2D>();
        if (col.CompareTag("OtherBall") && Mathf.Abs(rb.velocity.y) < 3f && Mathf.Abs(rb.velocity.x) < 3f)
        {
            Debug.Log("Оранжевый попал в лунку");
            Debug.Log(col.GetComponent<Rigidbody2D>().velocity);
        }

        if (col.CompareTag("MainBall") && Mathf.Abs(rb.velocity.y) < 3f && Mathf.Abs(rb.velocity.x) < 3f)
        {
            Debug.Log("Основной мяч попал в лунку");
            Debug.Log(col.GetComponent<Rigidbody2D>().velocity);
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
    }
}
