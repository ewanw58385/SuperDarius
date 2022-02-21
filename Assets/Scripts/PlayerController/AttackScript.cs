using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    float bulletSpeed = 500;
    float bombSpeed = 100;
    
    public Transform bulletFirePosition;
    public Rigidbody2D bulletPrefab;

    public Transform bombFirePosition;
    public Rigidbody2D bombPrefab;

    bool canFire = true;


    public void FireBullet()
    {
        Rigidbody2D bulletInstance;
        bulletInstance = Instantiate(bulletPrefab, bulletFirePosition.position, bulletFirePosition.rotation) as Rigidbody2D;
        bulletInstance.AddForce(Vector2.right * bulletSpeed);
    }
    
    public void FireBomb()
    {
        if (canFire)
        {
            StartCoroutine(PreventSpam());

            Rigidbody2D bombInstance;
            bombInstance = Instantiate(bombPrefab, bombFirePosition.position, bombFirePosition.rotation) as Rigidbody2D;
            bombInstance.AddForce(Vector2.right * bombSpeed);
        }
    }
    
    IEnumerator PreventSpam()
    {
        canFire = false;
        yield return new WaitForSeconds(0.3f);
        canFire = true;
    }

    public void DestroyPlayer()
    {
        Destroy(gameObject);
    }

}
