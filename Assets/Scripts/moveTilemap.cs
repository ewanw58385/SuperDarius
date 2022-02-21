using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTilemap : MonoBehaviour
{

    float moveSpeed = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(-1 * moveSpeed, 0, 0);
    }
}
