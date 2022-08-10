using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    Wall wall;
    Portal portal;
    private void OnCollisionEnter(Collision collision)
    {
        wall = collision.gameObject.GetComponent<Wall>();
        if (wall != null)
        {
            Debug.Log("this gameObject has Wall componenet");
        }
        else
        {
            Debug.Log("this gameObject dont have Wall component");
        }
        Debug.Log(collision.gameObject.name);
        //porqué collision.name no funciona??
    }
    private void OnTriggerEnter(Collider other)
    {
        portal = other.gameObject.GetComponent<Portal>();
        if (portal != null)
        {
            Debug.Log("this gameObject has Portal componenet");
        }
        else
        {
            Debug.Log("this gameObject dont have Portal component");
        }
    }
}
