using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCap : MonoBehaviour
{
    [SerializeField] LayerMask layermask;

  




    
    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 20f, layermask))
        {
            Debug.Log("Hit");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.red); 
        }
        else
        {
            Debug.Log("Boohoo");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.green);
        }
    }
}
