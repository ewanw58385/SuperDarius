using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOneScript : EnemyBaseBehavour
{

    private Vector2 attackPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();


        float positionToSpawnX = 35;
        float positionToSpawnY = -2f;

        MoveToPosition(positionToSpawnX, positionToSpawnY);
        StartCoroutine(MoveIntoView());
    }
    
}
