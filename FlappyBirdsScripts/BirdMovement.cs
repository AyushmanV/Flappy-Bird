﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody2D bird;
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up"))
        {
            bird.velocity = new Vector2(0 , speed);
        }
    }
}
