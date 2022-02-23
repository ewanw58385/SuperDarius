using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseBehavour : MonoBehaviour
{
    public float moveSpeed = 2f;

    public Transform bulletFirePos;
    public GameObject bulletPrefab;
    public float bulletSpeed = 550;

    protected float positionToMoveX;
    protected float positionToMoveY;

    public Animator anim;
    public Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    protected void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            anim.Play("Explode"); //plays animation
        }
    }

    public void EnemyDead() //called as animation event
    {
        Destroy(this.gameObject);
    }

    protected virtual void MoveToPosition(float positionToSpawnX, float positionToSpawnY)
    {
        transform.position = transform.position + new Vector3(positionToSpawnX, positionToSpawnY, 0);
    }

    protected virtual IEnumerator MoveIntoView()
    {
        rb.velocity = Vector2.left * moveSpeed;
        yield return new WaitForSeconds(1.5f);
        rb.velocity = Vector2.zero;

        FireWaveOne();
    }

    protected virtual IEnumerator InstantiateBullet(int amountOfProjectilesFired) //method for instanting projectile
    { 
        for (int i = 0; i < amountOfProjectilesFired; i++)
        {
            bulletFirePos = gameObject.transform.GetChild(0); //gets child of the enemies GO (fire position)
            GameObject enemyBullet = Instantiate(Resources.Load("EnemyBullet", typeof(GameObject)), bulletFirePos.position, bulletFirePos.rotation) as GameObject;
            //Instantiates bullet prefab from resources folder

            enemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.left * bulletSpeed); //gets rigidbody of prefab and applies velocity 

            yield return new WaitForSeconds(0.5f);
        }
    }


    protected virtual void FireWaveOne()
    {
        StartCoroutine(InstantiateBullet(5));
    }
}
