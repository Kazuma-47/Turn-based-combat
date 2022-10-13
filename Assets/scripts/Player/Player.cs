using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{
    private EnemiePlacer placer;
    Rigidbody2D body;
    float steps;
    private float horizontal, vertical;
    public float runSpeed;
    private bool cum = false;

    private void Start()
    {
        placer = GameObject.Find("placer").GetComponent<EnemiePlacer>();
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
        Debug.Log(steps);
        if(cum == true)
        {
            if (horizontal != 0 || vertical != 0)
            {
                steps += 5 * Time.deltaTime;
            }
            if (steps >= 3)
            {
                steps = 0;
                int _rand = Random.Range(0, 6);
                Debug.Log(_rand);
                if (_rand >= 5)
                {
                    placer.Encounter();
                }
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        cum = true;
        steps = 3;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        cum = false;
    }
}
