using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Rigidbody2D rb;
    public Transform rayAnchor;

    public float speed;
    public float jumpheight;
    public float jumpDistance;

    public bool moveInAir;

    bool onGround;
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

	}


    private void FixedUpdate() {
        if (onGround || moveInAir)
        {
            var walkforce = Input.GetAxis("Horizontal") * speed;

            rb.AddForce(transform.right * walkforce);
        }
        if (Input.GetButtonDown("Jump"))
            Jump();


        var hitInfo = Physics2D.Raycast(rayAnchor.position, -rayAnchor.up);
        onGround = hitInfo.collider != null && hitInfo.distance < jumpDistance;
    }

    void Jump() { 

         if(onGround) 
            rb.AddForce(rayAnchor.up * jumpheight);
    }

}
