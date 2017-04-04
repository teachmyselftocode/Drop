using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform player;

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;



    // Use this for initialization
    void Start() {

    }

	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector2(Mathf.Clamp(player.position.x, xMin, xMax), Mathf.Clamp(player.position.y, yMin, yMax));
    }
}
