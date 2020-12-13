using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class melee : MonoBehaviour
{
    public Animator ana;
    public Transform attackpoint;
    public float attackrange;
    public LayerMask enemylayer;
    public int damage = 20;
    public AudioSource a;

    public float starttimebtwattack;
    float timebtwatattack;



    // Update is called once per frame
    void Update()
    {
        if (timebtwatattack <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                attack();
                timebtwatattack = starttimebtwattack;
            }     
        }
        else
        {
            timebtwatattack -= Time.deltaTime;
        }
    }

    void attack()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemylayer);
        ana.SetTrigger("stab");
        a.Play();
        foreach (Collider2D item in hit)
        {
            //Debug.Log("we hit " + item.name);
            item.GetComponent<enemy>().takedamage(damage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
    }
}
