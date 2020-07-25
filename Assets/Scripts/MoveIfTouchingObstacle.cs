using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;

using Random = UnityEngine.Random;

public class MoveIfTouchingObstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player") return;
        transform.position = new Vector3(Random.Range(-17, 18), Random.Range(-8, 9));
    }
}