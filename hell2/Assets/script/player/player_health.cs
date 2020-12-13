using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{

    public int curret_health;
    public int max_health;



    // Start is called before the first frame update
    void Start()
    {
        curret_health = max_health;
    }

    // Update is called once per frame
    void Update()
    {
        if (curret_health <= 0)
        {
            die();
        }
    }
    public void take_damage(int damage)
    {
        curret_health -= damage;
    }
    void die()
    {
        Destroy(gameObject);
    }
}
