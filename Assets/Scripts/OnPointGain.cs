using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

using Object = UnityEngine.Object;

public class OnPointGain : MonoBehaviour
{
    public Rigidbody RB;
    public Object TailObject;
    public List<GameObject> TailUnits = new List<GameObject>();
    public float TimeChange;

    void Start()
    {
        TailUnits.Add((GameObject)Instantiate(TailObject, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0)));
        var newest = TailUnits.Last();
        newest.GetComponent<SpringJoint>().connectedBody = RB;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Tail")
        {
            TailUnits.Add(collision.collider.gameObject);
            TailUnits.Last().GetComponent<SpringJoint>().connectedBody = TailUnits[TailUnits.Count - 2].GetComponent<Rigidbody>();
            collision.collider.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        Unity.Mathematics.Random rnd = new Unity.Mathematics.Random();

        Instantiate(TailObject, new Vector3( rnd.NextInt(-8, 8), rnd.NextInt(-5, 5), 0), new Quaternion(0, 0, 0, 0));
    }
}