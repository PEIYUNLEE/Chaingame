using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomAttack : MonoBehaviour {
    public GameObject player;
    public PlayerHealth playerHealth;
    // Use this for initialization
    void Awake () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    
    void OnTriggerEnter(Collider other)
    {
        //If the entering collider is the player...
        if (other.gameObject == player) { Attack(); Debug.Log("N"); }
        //Attack(); Debug.Log("N");
    }
    void Attack()
    {
        PlayerHealth.damaged= true;
    }
}
