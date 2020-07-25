using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float MoveDistance = 1f;
    float TimeDif = 0;

    public static List<GameObject> TailUnits;

    Vector3 Direction;

    private void Start()
    { TailUnits = new List<GameObject>(); }

    private void Update()
    {
        TimeDif += Time.deltaTime;

        if (Input.GetKey("w"))
        {
            Direction = new Vector3();
            Direction.y += MoveDistance;
        }
        if (Input.GetKey("a"))
        {
            Direction = new Vector3();
            Direction.x -= MoveDistance;
        }
        if (Input.GetKey("s"))
        {
            Direction = new Vector3();
            Direction.y -= MoveDistance;
        }
        if (Input.GetKey("d"))
        {
            Direction = new Vector3();
            Direction.x += MoveDistance;
        }

        if (TimeDif < 1) return;
        TimeDif = 0;

        if (TailUnits.Count > 0)
        { MoveLastTailUnit(); }

        this.transform.position += Direction;
    }
    void MoveLastTailUnit()
    {
        TailUnits.Last().transform.position = this.transform.position;

        TailUnits.Insert(0, TailUnits.Last());

        TailUnits.RemoveAt(TailUnits.Count - 1);
    }
}