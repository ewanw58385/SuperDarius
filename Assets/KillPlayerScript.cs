using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerScript : MonoBehaviour
{
    [HideInInspector]
    public Animator anim;
    public GameObject player;

    void Start()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
        player = GameObject.Find("Player");

        if (player == null)
        {
            Debug.Log("no player found");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            anim.Play("playerDead");
            Destroy(gameObject);

        }
    }
}
