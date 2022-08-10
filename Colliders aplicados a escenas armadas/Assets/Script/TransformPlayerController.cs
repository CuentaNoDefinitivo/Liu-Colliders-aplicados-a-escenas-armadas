using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPlayerController : MonoBehaviour
{
    [SerializeField]float speed = 10;
    
    Vector3 direction = Vector3.zero;

    void Update()
    {
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction.z++;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction.z--;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x++;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction.x--;
        }
        transform.position += direction.normalized * speed * Time.deltaTime;
        //Porqué cuando muevo con transform, cuando se choca con la pared rebota?, con CharacterController esto no pasaba.
    }
}
