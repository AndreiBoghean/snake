using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PointGained : MonoBehaviour
{
    public Object TailObject;

    void Start()
    {
        var collision = (GameObject)Instantiate(TailObject, new Vector3(Random.Range(-16, 17), Random.Range(-9, 10)), new Quaternion());

        collision.gameObject.tag = "Obstacle";

        Movement.TailUnits.Add(collision.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Food")
        {
            if (Movement.TailUnits.Contains(collision.gameObject))
            { GameLost.Lost(); return; }
            else
            {
                collision.gameObject.tag = "Obstacle";

                Movement.TailUnits.Add(collision.gameObject);

                Instantiate(TailObject, new Vector3(Random.Range(-16, 17), Random.Range(-9, 10)), new Quaternion());
            }
        }
        else if (collision.collider.tag == "Obstacle")
        { GameLost.Lost(); return; }
    }
}