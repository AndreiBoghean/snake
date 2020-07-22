using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UI;

using Random = UnityEngine.Random;
using Object = UnityEngine.Object;
using UnityEngine.SceneManagement;

public class OnPointGain : MonoBehaviour
{
    public Object TailObject;
    public static List<GameObject> TailUnits = new List<GameObject>();

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            if (TailUnits.Contains(this.gameObject))
            {
                SceneManager.LoadScene("SampleScene"); return;
            }
            else
            {
                TailUnits.Add(this.gameObject);
                Instantiate(TailObject, new Vector3(Random.Range(-16, 17), Random.Range(-9, 10)), new Quaternion());
            }

        }
    }
}