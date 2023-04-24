using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] gunList;
    public GameObject cam;


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnCollisionEnter(Collision other)
    {
        

       if (other.gameObject.tag != "Bullet")
        Destroy(gameObject);

    }

}
