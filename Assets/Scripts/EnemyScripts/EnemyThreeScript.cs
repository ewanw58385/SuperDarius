using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThreeScript : EnemyBaseBehavour
{

    void Start()
    {
        positionToSpawnY = 0.19f;
        SetCorrectPosition();

        StartCoroutine(waitBeforeAttacking());
    }

    private IEnumerator waitBeforeAttacking()
    {
        yield return new WaitForSeconds(2.25f);
        FireWaveOne();
    }
}
