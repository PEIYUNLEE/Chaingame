using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int startingHealth;
    public int currentHealth;
    Animator anim;
    PlayerMovement playerMovement;
    public static bool isDead;
    public static bool damaged;
    // Use this for initialization
    void Awake () {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        playerMovement= GetComponent<PlayerMovement>();
        isDead = false;
        damaged = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (damaged) TakeDamage();
        if (isDead) Death();
	}

    void TakeDamage()
    {
        if (currentHealth == 1)
        {
            currentHealth=0;
            isDead = true;
            damaged = false;
        }
        else
        {
            currentHealth--;
            damaged = false;
        }
        GameObject.FindObjectOfType<HeartManager>().DecreaseLife();
    }

    void Death()
    {
        anim.SetTrigger("Die");
    }
}