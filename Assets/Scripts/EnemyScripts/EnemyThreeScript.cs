using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThreeScript : EnemyBaseBehavour
{

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        float positionToSpawnX = 35;
        float positionToSpawnY = -4.85f;

        MoveToPosition(positionToSpawnX, positionToSpawnY);
        StartCoroutine(MoveIntoView());
    }
}
