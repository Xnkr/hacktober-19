using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    public GameManager gameManager;
    Vector3 velocity;
    [Range(0,1)]
    public float speed = 0.1f;

    void Start()
    {
        ResetPosition();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity = velocity.normalized * speed;
        transform.position += velocity;
    }

    void ResetPosition(){
        transform.position = Vector3.zero;
        float z = Random.Range(0, 2) * 2f - 1f;
        float x = Random.Range(0, 2) * 2f - 1f * Random.Range(0.2f, 1f);
        velocity = new Vector3(x, 0, z);
        
    }

    void OnCollisionEnter(Collision collision){
        switch(collision.transform.name){
            case "Bound East":
            case "Bound West":
                velocity.x *= -1f;
                break;
            case "Bound North":
            case "Bound South":
                gameManager.IncScore(collision.transform.name);
                ResetPosition();
                break;
            case "Player Paddle":
            case "AI Paddle":
                velocity.z *= -1f;
                break;
        }
    }
}
