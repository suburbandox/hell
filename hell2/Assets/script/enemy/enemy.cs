using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public GameObject blood;
    public int maxhealth = 100;
    int currentheaith;


    // Start is called before the first frame update
    void Start()
    {
        currentheaith = maxhealth;
    }
    public void takedamage(int damage)
    {
        currentheaith -= damage;

        if (currentheaith <= 0)
        {
            die();
        }
    }
    void die()
    {
        Instantiate(blood, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
