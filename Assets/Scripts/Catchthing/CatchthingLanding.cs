using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchthingLanding : MonoBehaviour {
    public GameObject gameobject;
    public float speed ;
    private float destroyposY=-6f;  //the posy to destroy the catchthing
    private float movement;
    // Use this for initialization
    void Start () {
        speed = Random.Range(1.7f, 2f);
       
    }
	
	// Update is called once per frame
	void Update () {
        Move();
        if (transform.position.y < destroyposY)
        {
            Destroy(gameobject);
        }
    }

    void Move()
    {
        movement = speed * Time.deltaTime;
        gameobject.transform.Translate(0,-movement, 0);
    }
}
