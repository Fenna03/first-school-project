using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed = 3f;
    public bool Bottom = false;
    public bool Top = false;

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
            if(speed <= 6)
            {
                speed *= 1.1f;
            }
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
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Bottom = false;
        Top = false;
    }

}
