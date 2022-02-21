using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseBehavour : MonoBehaviour
{
    public GameObject groundingPoint;

    public float positionToSpawnX = 0f;
    public float positionToSpawnY = 0f;

    public float moveSpeed = 10f;

    public Transform bulletFirePos;
    public GameObject bulletPrefab;
    public float bulletSpeed = 550;

    public Animator anim;
    public Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

        protected virtual void InstantiateBullet() //method for instanting projectile
    { 
        bulletFirePos = this.gameObject.transform.GetChild(0); //gets child of the enemies GO (fire position)
        GameObject enemyBullet = Instantiate(Resources.Load("EnemyBullet", typeof(GameObject)), bulletFirePos.position, bulletFirePos.rotation) as GameObject;
        //Instantiates bullet prefab from resources folder
        
        enemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.left * bulletSpeed); //gets rigidbody of prefab and applies velocity 

    }

    protected virtual void SetCorrectPosition() //sets the enemy prefabs to their correct positions
    {
        groundingPoint  = GameObject.Find("groundingPoint");
        transform.parent = groundingPoint.transform; //makes enemies a child of the tilemap so they move into the camera's view

        transform.position = transform.position + new Vector3 (positionToSpawnX * moveSpeed, positionToSpawnY * moveSpeed, 0); //move enemies into positions 

        StartCoroutine(DetachFromWall()); //detach from tilemap after 1 second

    }

    protected virtual IEnumerator DetachFromWall() //detaches enemies from the tilemap to keep in view of camera 
    {
        yield return new WaitForSeconds(1); //wait 1 second before detaching from wall
        transform.parent = null; //detach from wall so enemies stay in camera view
    }


    protected virtual IEnumerator FireWeapon(int amountOfProjectilesFired) //method to call the instantiatebullet method, with a pause between each projectile fired
    {
        for (int i = 0; i < amountOfProjectilesFired; i++)
        {
            InstantiateBullet();
            yield return new WaitForSeconds(0.5f);
        }
    }

    protected virtual void FireWaveOne()
    {
        StartCoroutine(FireWeapon(5));
    }
    
    protected virtual void FireWaveTwo()
    {

    }

    protected virtual void FireWaveThree()
    {

    }

    protected virtual void FlyAway()
    {

    }
}
