using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenToDestroy : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;

    GameObject wallsToStick;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
        wallsToStick = GameObject.Find("Walls");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Walls")
        {
            transform.parent = wallsToStick.transform;

            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY; //freeze position
            anim.Play("Explode"); //play attack anim
        }
    }
    

    public void DestroyBomb()
    {
        Destroy(gameObject);
    }

}
