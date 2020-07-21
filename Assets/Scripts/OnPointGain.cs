using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UI;

using Random = UnityEngine.Random;
using Object = UnityEngine.Object;

public class OnPointGain : MonoBehaviour
{
    public Object TailObject;
    public static List<GameObject> TailUnits = new List<GameObject>();
    

    //public GameObject ThisObj;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            var ThisObj = (GameObject)Instantiate(TailObject, new Vector3( Random.Range(-16, 17) , Random.Range(-10, 11) ), new Quaternion());

            TailUnits.Add(ThisObj);
        }
    }
}