using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float pipeVelocity, score;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        Destroy(gameObject, 5f);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * (pipeVelocity+score) * Time.deltaTime;
        score = (float)gameManager.score/25;
    }
}
