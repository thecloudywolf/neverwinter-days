using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{ 
    public Rigidbody projectile;
public float speed = 1190;
    public double r = -1.5;
    Rigidbody instantiatedProjectile;
// Update is called once per frame
void Update()
{
    if (Input.GetButtonDown("Fire1"))
    {
         instantiatedProjectile = Instantiate(projectile, transform.position + new Vector3(0,(float)r,0) , transform.rotation) as Rigidbody;
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed * 4));
    }
}


    void OnTriggerEnter(Collider other)
    {


        Destroy(instantiatedProjectile);


    }
}
