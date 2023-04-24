using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed = 10f; //sets Speed
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
          rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); //basic horizontal movement
        float zMove = Input.GetAxisRaw("Vertical"); //basic vertical movement
        rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed; //creates velocity to use for speed
    }
}
