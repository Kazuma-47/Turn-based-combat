using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{
    Rigidbody2D body;
    float steps;
    [HideInInspector]
    public float horizontal, vertical;
    public float runSpeed;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
}
