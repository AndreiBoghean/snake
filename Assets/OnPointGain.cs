using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

using Object = UnityEngine.Object;

public class OnPointGain : MonoBehaviour
{
    public Rigidbody RB;
    public Object TailObject;
    public List<GameObject> TailUnits = new List<GameObject>();

    void Start()
    {
        TailUnits.Add((GameObject)Instantiate(TailObject, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0)));
        var newest = TailUnits.Last();
        newest.GetComponent<SpringJoint>().connectedBody = RB;
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Return))
        { AddTailUnit(); }
    }
    public void AddTailUnit()
    {
        TailUnits.Add((GameObject)Instantiate(TailObject, TailUnits.Last().transform.position, new Quaternion(0, 0, 0, 0)));
        TailUnits.Last().GetComponent<SpringJoint>().connectedBody = TailUnits[TailUnits.Count - 2].GetComponent<Rigidbody>();
    }
}