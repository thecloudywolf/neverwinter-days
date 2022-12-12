using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{ 
    public Rigidbody projectile;
public float speed = 1190;

// Update is called once per frame
void Update()
{
    if (Input.GetButtonDown("Fire1"))
    {
        Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position + new Vector3(0,-1,0) , transform.rotation) as Rigidbody;
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed * 4));
    }
}
}

