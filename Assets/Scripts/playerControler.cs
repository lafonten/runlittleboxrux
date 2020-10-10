using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float velocity;
    private float axisCoordinate;
    public bool isDead;
    public GameManager gM;

    void Start()
    {
        Time.timeScale = 1;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        axisCoordinate = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(axisCoordinate * velocity, rigidBody.velocity.y);
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 3));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0f, 0f, -3));
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("losearea"))
        {
            isDead = true;
            Time.timeScale = 0;
            gM.Dead();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("score"))
        {
            gM.UpdateScore();   
        }
    }
}
