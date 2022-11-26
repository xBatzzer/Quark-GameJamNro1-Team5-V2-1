﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndlessScroll : MonoBehaviour
{

    [SerializeField] private float scrollFactor = -1f;
    [SerializeField] private Vector3 gameVelocity;

    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameVelocity * scrollFactor;
    }
         
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider gameArea)
    {
        if (gameArea.gameObject.tag.Equals("GameArea"))
        {
            transform.position += Vector3.right * (gameArea.bounds.size.x + GetComponent<BoxCollider>().size.x);
        }        
    }


}

