using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GunPosition : MonoBehaviour
{

    public GameObject cameraaaa;
    public GameObject player;

   // public int[] gunArray = { 1, 2, 3 };


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
if (Input.GetKeyDown(KeyCode.F))
        {
            cameraaaa.transform.position = new Vector3(player.transform.position.x, player.transform.position.y , player.transform.position.z );


        }
    }

}
