using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoScript : EnemyBaseBehavour
{

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();


        float positionToSpawnX = 35;
        float positionToSpawnY = 0.65f;


        MoveToPosition(positionToSpawnX, positionToSpawnY);
        StartCoroutine(MoveIntoView());
    }
}
