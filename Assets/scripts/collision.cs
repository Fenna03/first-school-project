using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 4f;
    public float ySpeed = 4f;
    public TMP_Text scoreText;
    public int leftScore = 0;
    public int rightScore = 0;

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
            xSpeed = xSpeed * -1f;
        }
        else if(collision.gameObject.CompareTag("wallleft"))
        {
            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            rightScore++;
            scoreText.text = leftScore + " | " + rightScore;
        }
        else if (collision.gameObject.CompareTag("wallright"))
        {
            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            leftScore++;
            scoreText.text = leftScore + " | " + rightScore;
        }
        else if(collision.gameObject.CompareTag("Player"))
        {
            xSpeed *= -1.1f;
        }
    }
}
