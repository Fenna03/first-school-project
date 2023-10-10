using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 4f;
    public float ySpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontal") || collision.gameObject.CompareTag("horizontal2"))
        {
            //Debug.Log("AUW! MY HEAD OR FEET");
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("vertical"))
        {
            //Debug.Log("AUW! MY SIDES");
            xSpeed = xSpeed * -1.1f;
        }
        else if(collision.gameObject.CompareTag("wallleft"))
        {
            xPosition = 0f;
            yPosition = 0f;
        }
        else if (collision.gameObject.CompareTag("wallright"))
        {
            xPosition = 0f;
            yPosition = 0f;
        }

    }
}
