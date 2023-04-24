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

        if (Input.GetButtonDown("Fire2"))
        {
          
            Destroy(cam.transform.GetChild(0).gameObject);
          //  gunList[2].transform.SetParent(cam.transform);
            gunList[2].transform.position = cam.transform.position + new Vector3(5,6,-12);

            gunList[2].transform.rotation = cam.transform.rotation;          
         gunList[2].transform.parent = cam.transform;
              
                   
        }


    }  
}
