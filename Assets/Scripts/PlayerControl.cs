﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float speed;

    private Rigidbody2D playerRigidbody;

    // public GameObject bullet;

	// Use this for initialization
	void Start ()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate()
    {
        MovePlayer();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    // Move the player
    void MovePlayer()
    {
        float horzMove = Input.GetAxisRaw("Horizontal");

        playerRigidbody.velocity = new Vector2(horzMove, 0f) * speed;
    }
}
