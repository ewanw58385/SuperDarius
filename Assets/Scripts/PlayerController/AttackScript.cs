using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public float bulletSpeed = 500;
    public float bombSpeed = 100;
    
    [HideInInspector]
    public Transform bulletFirePosition;
    [HideInInspector]
    public Rigidbody2D bulletPrefab;

    [HideInInspector]
    public Transform bombFirePosition;
    [HideInInspector]
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
