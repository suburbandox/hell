using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pi : MonoBehaviour
{

    public float sp;
    public float lifetime;
    public GameObject dedfx;
    public float dis;
    public LayerMask solid;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ded", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.up, dis, solid);
        if (ray.collider != null)
        {
            if (ray.collider.CompareTag("enemy"))
            {
                //Debug.Log("uh o");
                ray.collider.GetComponent<enemy>().takedamage(damage);
            }
            ded();
        }
        transform.Translate(Vector2.up * sp * Time.deltaTime);
    }
    void ded()
    {
        Instantiate(dedfx,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}
