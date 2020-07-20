using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public enum MovementMethod
    { speed, teleport, Gravity }
    public MovementMethod SelectedMovement;

    public Rigidbody rb;

    public float Speed = 100f;
    public float Teleport = 50f;
    public float Gravity = 9.81f;
    private void FixedUpdate()
    {

        switch (SelectedMovement)
        {
            case MovementMethod.Gravity:
                #region gravity

                if (Input.GetKey("w"))
                {
                    Physics.gravity = new Vector3(0, Gravity, 0);
                }
                else if (Input.GetKey("a"))
                {
                    Physics.gravity = new Vector3(-Gravity, 0, 0);
                }
                else if (Input.GetKey("s"))
                {
                    Physics.gravity = new Vector3(0, -Gravity, 0);
                }
                else if (Input.GetKey("d"))
                {
                    Physics.gravity = new Vector3(Gravity, 0, 0);
                }
                else
                { Physics.gravity = Vector3.zero; }

                System.Console.WriteLine(Physics.gravity);
                #endregion
                break;

            case MovementMethod.speed:
                #region speed
                float NewSpeed = Speed * Time.deltaTime;
                if (Input.GetKey("w"))
                {
                    rb.AddForce(new Vector3(0, NewSpeed), ForceMode.VelocityChange);
                }
                if (Input.GetKey("a"))
                {
                    rb.AddForce(new Vector3(-NewSpeed, 0), ForceMode.VelocityChange);
                }
                if (Input.GetKey("s"))
                {
                    rb.AddForce(new Vector3(0, -NewSpeed), ForceMode.VelocityChange);
                }
                if (Input.GetKey("d"))
                {
                    Physics.gravity = new Vector3();
                    rb.AddForce(new Vector3(NewSpeed, 0), ForceMode.VelocityChange);
                }
                #endregion
                break;

            case MovementMethod.teleport:
                #region teleport
                float x = this.transform.position.x;
                float y = this.transform.position.y;
                float z = this.transform.position.z;
                float NewDistance = Teleport * Time.deltaTime;
                if (Input.GetKey("w"))
                {
                    this.transform.position = new Vector3(x, y + NewDistance, z);
                }
                if (Input.GetKey("a"))
                {
                    this.transform.position = new Vector3(x - NewDistance, y, z);
                }
                if (Input.GetKey("s"))
                {
                    this.transform.position = new Vector3(x, y - NewDistance, z);
                }
                if (Input.GetKey("d"))
                {
                    this.transform.position = new Vector3(x + NewDistance, y, z);
                }
                #endregion
                break;
        }
    }
}