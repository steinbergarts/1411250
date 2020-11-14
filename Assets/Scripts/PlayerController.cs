using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // float бо число швидкості може бути дробовим + після числа треба f
    public float jumpSpeed = 5f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>(); //звертаємося до ріджіт боді
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis ("Horizontal");

        if(movement > 0f){
            rigidBody.velocity = new Vector2(movement*speed, rigidBody.velocity.y);
        }
        else if (movement < 0f){
            rigidBody.velocity = new Vector2(movement*speed, rigidBody.velocity.y);
        }
        else {
            rigidBody.velocity = new Vector2 (0, rigidBody.velocity.y);
        }
        
        if(Input.GetButtonDown ("Jump")){
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
        
    }
}
