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
    public int winScore = 0;
    public bool pause = false;
    public new AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
        audio = GetComponent<AudioSource>();
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

        if(leftScore >= 15)
        {
            scoreText.text = "Left player has won!";
            xPosition = 0;
            yPosition = 0;
        }
        if(rightScore >= 15)
        {
            scoreText.text = "Right player has won!";
            xPosition = 0;
            yPosition = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("horizontal") || collision.gameObject.CompareTag("horizontal2"))
            audio.Play();

        {
            //Debug.Log("AUW! MY HEAD OR FEET");
            ySpeed = ySpeed * -1f;
        }
        if (collision.gameObject.CompareTag("vertical") || collision.gameObject.CompareTag("vertical2"))
        {
            audio.Play();

            if (xSpeed >= 8 || xSpeed <= -8)
            {
                //Debug.Log("AUW! MY SIDES");
                xSpeed = xSpeed * -1f;
            }
            else
            {
                xSpeed = xSpeed * -1.1f;
            }
        }
        if(collision.gameObject.CompareTag("wallleft"))
        {

            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            rightScore++;
            scoreText.text = leftScore + " | " + rightScore;
        }
        if (collision.gameObject.CompareTag("wallright"))
        {

            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            leftScore++;
            scoreText.text = leftScore + " | " + rightScore;
        }
    }

    public void pausefunction()
    {
        pause = !pause;

        gameObject.SetActive(!pause);

    }
}
