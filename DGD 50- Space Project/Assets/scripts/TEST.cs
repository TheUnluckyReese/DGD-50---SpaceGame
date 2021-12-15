using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
    }
}
