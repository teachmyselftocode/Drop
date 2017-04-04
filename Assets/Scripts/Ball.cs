using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D RB;
	void Start ()
    {
        RB = gameObject.GetComponent<Rigidbody2D>();
	}
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RB.velocity = new Vector2(0, speed);
        }
	}
}
