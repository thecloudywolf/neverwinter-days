using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class chase : MonoBehaviour
{

    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 100;
    int MinDist = 0;
    public float  ZomHealth = 5f;
    public float  MaxZomHealth = 5f;
    public float damage = 1f;

        public GameObject textShow;
    public TMP_Text canvasText;
    public static int Global = 0;


    void  waiter()
    {
        Global += 1;
        canvasText.text = Global.ToString();



    }


    void Start()
    {
        ZomHealth = MaxZomHealth;
    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }

        }
        if (ZomHealth < 1)
        {
            waiter();
            Destroy(gameObject);
            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            ZomHealth = ZomHealth - damage;
        }
    }
}