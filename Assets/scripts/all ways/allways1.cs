using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allways1 : MonoBehaviour
{
    public float speed = 3f;
    public bool Bottom = false;
    public bool Top = false;
    public bool Left = false;
    public bool Right = false;

    void paddleControl()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if(!Top) 
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (!Bottom)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (!Left)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (!Right)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
    } 

    // Update is called once per frame
    void Update()
    {
        paddleControl();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            speed *= 1.15f;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontal"))
        {
            Bottom = true;
        }
        if (collision.gameObject.CompareTag("horizontal2"))
        {
            Top = true;
        }
        if (collision.gameObject.CompareTag("vertical"))
        {
            Right = true;
            Left = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Bottom = false;
        Top = false;
        Left = false;
        Right = false;
    }

}
