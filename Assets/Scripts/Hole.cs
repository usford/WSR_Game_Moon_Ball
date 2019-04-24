using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (col.CompareTag("OtherBall") && Mathf.Abs(rb.velocity.y) < 2f && Mathf.Abs(rb.velocity.x) < 2f)
        {
            Debug.Log("Оранжевый попал в лунку");
            Debug.Log(col.GetComponent<Rigidbody2D>().velocity);
        }
    }
}
