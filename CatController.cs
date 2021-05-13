using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public bool isDead;     //default false

    public float jumpSpeed=1f;
    private Rigidbody2D rb2D;

    private GameManager gameManager;
    
    void Start(){
        gameManager = FindObjectOfType<GameManager>();
        rb2D = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //0:Left Click, 1:Right Click
            rb2D.velocity = Vector2.up * jumpSpeed;     //Jumping 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
            gameManager.UpdateScore();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            gameManager.GameOver();
        }
    }

}
