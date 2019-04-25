using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBall : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject cube; //Точка поворота у стрелки
    public GameObject arrow; //Наша стрелка

    private bool checkClick = false; //Проверка на нажатие
    private bool checkExit = false; //Проверка на покидание коллайдера

    //Ммммм
    Vector3 heading;

    Vector3 mouse; //Координаты наше мышки в момент запуска шарика
    Vector3 mousePosition; //Координаты нашей мышки



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cube = GameObject.Find("Cube");
        cube.SetActive(false);
        Cursor.visible = true;
    }

    private void FixedUpdate()
    {
        
    }

    void Update()
    {
        //Запускаем наш мяч
        if (Input.GetKeyDown(KeyCode.Mouse0) && checkClick && checkExit)
        {
            checkClick = false;        
            cube.SetActive(false);
            Cursor.visible = true;
            mouse = mousePosition;
            heading = mouse - transform.position;


            rb.AddForce(heading, ForceMode2D.Impulse);

            
            Debug.Log("Мяч запущен");
        }

        if (checkClick) Acceleration();



    }

    void OnMouseDown()
    {
        checkClick = true;
        checkExit = false;
        Debug.Log("Произошло нажатие на мяч");
        cube.SetActive(true);
        Cursor.visible = false;

    }

    void OnMouseExit()
    {
        checkExit = true;
    }

    /// <summary>
    /// Задатие направления и ускорения для мяча
    /// </summary>
    void Acceleration()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); mousePosition.z = 0;
        var angle = Vector2.Angle(Vector2.right, mousePosition - cube.transform.position);
        var arrowTransform = arrow.transform.position;
        arrowTransform.y = (Mathf.Abs(mousePosition.x - cube.transform.position.x) + Mathf.Abs(mousePosition.y - cube.transform.position.y)) / 3;

        cube.transform.eulerAngles = new Vector3(0f, 0f, (cube.transform.position.y < mousePosition.y ? angle : -angle) + 90f);

        arrow.transform.localScale = new Vector3(arrow.transform.localScale.x, Mathf.Clamp(arrowTransform.y, 0f, 0.56f), arrow.transform.localScale.z);
        
    }
}
