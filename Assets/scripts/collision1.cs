using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class collision1 : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 2f;
    public float ySpeed = 4f;
    public TMP_Text scoreText;
    public int leftScore = 0;
    public int rightScore = 0;
    public int winScore = 0;
    public bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (pause == false)
        {
            xPosition = xPosition + xSpeed * Time.deltaTime;
            yPosition = yPosition + ySpeed * Time.deltaTime;
            transform.position = new Vector3(xPosition, yPosition, 0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("vertical") || collision.gameObject.CompareTag("vertical2"))
        {
            //Debug.Log("AUW! MY SIDES");
            xSpeed = xSpeed * -1.1f;
        }
        else if (collision.gameObject.CompareTag("horizontal"))
        {
            if (ySpeed >= 6 || ySpeed <= -6)
            {
                //Debug.Log("AUW! MY SIDES");
                ySpeed = ySpeed * -1f;
            }
            else
            {
                ySpeed = ySpeed * -1.1f;
            }
        }
        if(collision.gameObject.CompareTag("brick"))
        {
            Destroy(collision.gameObject);
            ySpeed = ySpeed * -1f;
        }
        if (collision.gameObject.CompareTag("wallleft"))
        {
            ySpeed = ySpeed * -1f;
            xPosition = 0f;
            yPosition = -3.15f;
        }
    }

    public void pausefunction()
    {
        pause = !pause;

        gameObject.SetActive(!pause);

    }
}