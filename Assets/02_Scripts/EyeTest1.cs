using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTest1 : MonoBehaviour
{
    public GameObject demoObject;
    public float forceAmount;
    public Material flatMaterial;
    public Material objectMaterial;
    //public GameObject VFX1;
    Rigidbody rb;
    MeshRenderer mr;

    void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
        mr = demoObject.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        // Check if object is rotating and change material accordingly
        if (!rb.IsSleeping())
        {
            mr.material = objectMaterial;
        }
        else
        {
            mr.material = flatMaterial;
        }
    }

    // Rotates object hit with gaze tracking raycast
    public void RayHit()
    {
        rb.AddTorque(Vector3.up * forceAmount * Time.deltaTime, ForceMode.Force);
        //InstVFX();
    }

    /* public void InstVFX()
    {
        Instantiate(VFX1, Vector3.zero, Quaternion.identity);
    } */


}
