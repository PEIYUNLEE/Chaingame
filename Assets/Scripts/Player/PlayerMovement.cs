using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed=6.0f;
    private Vector2 movement; 
    private Animator anim;
    private Rigidbody playerRigidbody;
    PlayerHealth playerHealth;
    // Use this for initialization
    void Awake () {
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerHealth = GetComponent<PlayerHealth>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float y = Input.GetAxisRaw("Horizontal");
        if (!PlayerHealth.isDead)
        {
            Move(y);
            Animate(y);
        }
        
    }

    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.LeftArrow))
    //        playerRigidbody.transform.Rotate(new Vector2(0, -180));
    //    if (Input.GetKey(KeyCode.RightArrow))
    //        playerRigidbody.transform.Rotate(new Vector2(0, 180));
    //}

    void Move(float y)
    {
        movement.Set(y,0f);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.transform.Translate(movement,0);
    }

    void Animate(float y)
    {
        bool walking = y != 0f;
        anim.SetBool("IsWalking", walking);
    }

}

