using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
    //private MenuPanel menuPanel;
    public GameObject panel;

    void Awake()
    { 
}

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Rigidbody2D rb = col.GetComponent<Rigidbody2D>();

        if (Mathf.Abs(rb.velocity.y) < 3f && Mathf.Abs(rb.velocity.x) < 3f)
        {
            if (col.CompareTag("OtherBall"))
            {
                Debug.Log("Оранжевый попал в лунку");
                SceneManager.LoadScene("Level2", LoadSceneMode.Single);
            }

            if (col.CompareTag("MainBall"))
            {
                Debug.Log("Основной попал в лунку");
                panel.SetActive(true);
                Cursor.visible = true;
                SceneManager.LoadScene("Level2", LoadSceneMode.Single);
            }

            Destroy(col.gameObject);
        }
    }
}
