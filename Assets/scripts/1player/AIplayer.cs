using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class AIplayer : MonoBehaviour
{
    public float xPosition = 7.5f;
    public float yPosition =0f;
    public float xSpeed = 4f;
    public float ySpeed = 4f;
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
            yPosition = yPosition + ySpeed * Time.deltaTime;
            transform.position = new Vector3(xPosition, yPosition, 0f);
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontal") || collision.gameObject.CompareTag("horizontal2"))
        {
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("ball"))
        {
            ySpeed *= 1.15f;
        }
    }

    public void pausefunction()
    {
        pause = !pause;

        gameObject.SetActive(!pause);

    }
}
