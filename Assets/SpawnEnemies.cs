using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    public GameObject enemyPrefab;

    public GameObject enemySpawnPos;

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject enemyInstanceOne;
            GameObject enemyInstanceTwo;
            GameObject enemyInstanceThree;

            enemyInstanceOne = Instantiate(enemyPrefab, enemySpawnPos.transform.position, enemySpawnPos.transform.rotation) as GameObject;
            enemyInstanceOne.AddComponent<EnemyOneScript>();

            enemyInstanceTwo = Instantiate(enemyPrefab, enemySpawnPos.transform.position, enemySpawnPos.transform.rotation) as GameObject;
            enemyInstanceTwo.AddComponent<EnemyTwoScript>();

            enemyInstanceThree = Instantiate(enemyPrefab, enemySpawnPos.transform.position, enemySpawnPos.transform.rotation) as GameObject;
            enemyInstanceThree.AddComponent<EnemyThreeScript>();
        }
    }
}
