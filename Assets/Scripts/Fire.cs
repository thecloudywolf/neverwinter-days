using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{ 
    public Rigidbody projectile;
public float speed = 1190;
    public double r = -0.2;
    Rigidbody instantiatedProjectile;
    public int angle = 90;


    void OnTriggerEnter(Collider other)
    {


       Destroy(instantiatedProjectile.gameObject);

       
    }
    // Update is called once per frame
    void Update()
{
    if (Input.GetButtonDown("Fire1"))
    {
            for (int  i = 0; i < 12; i ++ ) { 
         instantiatedProjectile = Instantiate(projectile, transform.position + new Vector3(0,(float)r  + (-1) ,0) , transform.rotation) as Rigidbody;
                instantiatedProjectile.transform.Rotate(new Vector3(Random.Range(-15, 15), Random.Range(-angle, angle), Random.Range(-angle, angle)) );
                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed * 4));


                instantiatedProjectile.velocity = instantiatedProjectile.transform.TransformDirection(new Vector3(0, 0, speed * 4));

            }
        }
}


   
}
