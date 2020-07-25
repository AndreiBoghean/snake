using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourOnStart : MonoBehaviour
{
    public Material Mat;
    public Camera Cam;

    void Start()
    { Cam.backgroundColor = Mat.color; }
}
