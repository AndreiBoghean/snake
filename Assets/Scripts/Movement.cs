using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public enum MovementMethod
    { speed, teleport }
    public MovementMethod SelectedMovement;

    public Rigidbody rb;

    public float MoveDistance = 1f;
    public float TimeDif = 0;

    Vector3 Direction;
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

        if (TimeDif < 0.1) return;
        TimeDif = 0;

        if (OnPointGain.TailUnits.Count > 0)
        { MoveLastTailUnit(); }

        this.transform.position += Direction;
    }
    void MoveLastTailUnit()
    {
        OnPointGain.TailUnits.Last().transform.position = this.transform.position;
        OnPointGain.TailUnits.Insert( 0, OnPointGain.TailUnits.Last() );

        var temp = OnPointGain.TailUnits[OnPointGain.TailUnits.Count - 1];
        OnPointGain.TailUnits.RemoveAt(OnPointGain.TailUnits.Count - 1);
        Destroy(temp);
    }
}