using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 100f;


    void Start()
    {

    }
    private void FixedUpdate()
    {
        float DeltaSpeed = Speed * Time.deltaTime;

        #region
        
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(0, DeltaSpeed), ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(-DeltaSpeed, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(0, -DeltaSpeed), ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(DeltaSpeed, 0), ForceMode.VelocityChange);
        }

        #endregion new movement

        #region old movement
        /*
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float z = this.transform.position.z;

        if (Input.GetKey("w"))
        {
            this.transform.position = new Vector3(x, y + DeltaSpeed, z);
        }
        if (Input.GetKey("a"))
        {
            this.transform.position = new Vector3(x - DeltaSpeed, y, z);
        }
        if (Input.GetKey("s"))
        {
            this.transform.position = new Vector3(x, y - DeltaSpeed, z);
        }
        if (Input.GetKey("d"))
        {
            this.transform.position = new Vector3(x + DeltaSpeed, y, z);
        }
        */
        #endregion
    }
}
