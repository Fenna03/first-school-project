using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class optionsAway : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 2f;
    public float ySpeed = 4f;
    public TMP_Text scoreText;
    public bool pause = false;
    public new AudioSource audio;



    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (pause == false)
        {
            if (collision.gameObject.CompareTag("brick"))
            {
                audio.Play();
                Destroy(collision.gameObject);
                ySpeed = ySpeed * -1f;
            }
        }

    }

    public void pausefunction()
    {
        pause = !pause;

        gameObject.SetActive(!pause);

    }
}