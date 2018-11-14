using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 3;
    private Rigidbody rb;
    public float maxSpeed = 5;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.D))
        {
            if (rb.velocity.magnitude < maxSpeed)
            {
                rb.AddForce(Vector3.right * speed);
            }

        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (rb.velocity.magnitude < maxSpeed)
            {
                rb.AddForce(Vector3.left * speed);
            }
        }
        else rb.velocity = new Vector3(Mathf.Lerp(rb.velocity.x, 0, 0.01f), rb.velocity.y, 0);
    }
}
