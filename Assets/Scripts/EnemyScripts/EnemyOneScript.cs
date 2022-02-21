using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOneScript : EnemyBaseBehavour
{

    private Vector2 attackPosition;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        SetCorrectPosition(); 

        StartCoroutine(waitBeforeAttacking());
    }

    private IEnumerator waitBeforeAttacking()
    {
        yield return new WaitForSeconds(2.25f);
        FireWaveOne();
    }
    
}
