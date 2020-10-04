using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(RigidBody2D))]
public class ShipBehav : MonoBehaviour
{
    RigidBody2D rb;
    public float Velocidad = 8f;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<RigidBody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Velocidad * (Input.GetAxis("Horizontal") * Vector3.right + Input.GetAxis("Vertical") * Vector3.foward)
    }
}
