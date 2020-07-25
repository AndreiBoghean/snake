using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using TMPro;
using UnityEngine;

public class PointGained : MonoBehaviour
{
    private int _points;
    public int points
    {
        get { return _points; }
        set {  _points = value; text.text = "score: " + value; }
    }
    public TMP_Text text;
    public Object TailObject;

    void Start()
    {
        Instantiate(TailObject, new Vector3(Random.Range(-16, 17), Random.Range(-9, 10)), new Quaternion());
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.tag == "Food") && !Movement.TailUnits.Contains(collision.gameObject))
        {
            points++;

            collision.gameObject.tag = "Obstacle";

            collision.gameObject.transform.position = new Vector3(0, 0, -21);

            Movement.TailUnits.Add(collision.gameObject);

            Instantiate(TailObject, new Vector3(Random.Range(-16, 17), Random.Range(-9, 10)), new Quaternion());

        }
        else if (collision.collider.tag == "Obstacle" || Movement.TailUnits.Contains(collision.gameObject))
        { GameLost.Lost(); return; }
    }
}