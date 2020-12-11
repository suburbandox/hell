using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee : MonoBehaviour
{
    public Animator ana;
    public Transform attackpoint;
    public float attackrange;
    public LayerMask enemylayer;
    public int damage = 20;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack();
        }
    }

    void attack()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(attackpoint.position, attackrange, enemylayer);
        ana.SetTrigger("swipe");
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
