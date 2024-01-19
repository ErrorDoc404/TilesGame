using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int Speed = 5;
    public Rigidbody2D rigidBody;
    public Transform BlockTrans;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            OnMoveBall();
        }
    }
    public void OnMoveBall()
    {
        Debug.Log("Move check");
        if (rigidBody.velocity.magnitude == 0f)

        {
            rigidBody.velocity = Vector2.one * Speed;
            transform.SetParent(null);
        }
    }
       private void OnTriggerEnter2D(Collider2D collision)

        {
            if (collision.CompareTag("GameOver"))
            {
                Debug.Log("gameover");
            }
        }
   
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.CompareTag("Brick"))
            {
                if (BlockTrans.childCount <= 1)
                {
                    Debug.Log("Game Win");
                }
                Destroy(collision.gameObject);
            }

        }
    
}
