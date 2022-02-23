using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemapIllusion : MonoBehaviour
{

    public float moveSpeed;

    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(1 * moveSpeed, 0, 0);
    }
}
