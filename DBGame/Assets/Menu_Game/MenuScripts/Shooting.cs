using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Lanzador;

    public GameObject DisparoPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate (DisparoPrefab, Lanzador.position, DisparoPrefab.transform.rotation);
        }
    }
}
