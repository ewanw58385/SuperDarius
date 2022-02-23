using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParralaxScript : MonoBehaviour
{
    public Transform cam;
    public float relativeMove = 3f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector2(cam.position.x * relativeMove, 0);
    }
}
