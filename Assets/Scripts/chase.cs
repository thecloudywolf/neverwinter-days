using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class chase : MonoBehaviour
{

    public Transform Player;
    public float MoveSpeed;
    int MaxDist = 100;
    int MinDist = 0;
    public float ZomHealth = 5f;
    public float MaxZomHealth = 5f;
    public float damage = 1f;
    public float MaxMoveSpeed;
    public int TotalScore;
    public TextMeshProUGUI shootText; 


    void Start()
    {
        ZomHealth = MaxZomHealth;
        MoveSpeed = 0.02f;
    }
    
    void Update()
    {
        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            Vector3 temp = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, temp, MoveSpeed);
        }
        if (ZomHealth < 1)
        {
            TotalScore = PlayerPrefs.GetInt("Score", 0);
            TotalScore++;
            PlayerPrefs.SetInt("Score", TotalScore);
            PlayerPrefs.Save();

            shootText.text = "Score: " +TotalScore.ToString();
                Destroy(gameObject);

        }

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            ZomHealth = ZomHealth - damage;
        }
    }
}