using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Controller2D))]
public class Player : MonoBehaviour
{

    Controller2D controller;
    public Rigidbody2D rb;


    public float fly = 10f;
    public float thrust = 50f;
    public float yDisplacement = 500;


    public virtual void Awake()
    {


    }

    public virtual void Start()
    {
        controller = GetComponent<Controller2D>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, yDisplacement) * thrust);

        }

    }


}