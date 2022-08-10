using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    float time;

    private void OnCollisionEnter(Collision collision)
    {
        //¿el gameObject es una variable de tipo GameObject que unity ya lo ha creado, como el transform?
        if (collision.gameObject.CompareTag("Player")) 
        {
            time = 0; 
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            if (time <= 2)
            {
                time += Time.deltaTime;
            }
            else
            {
                collision.transform.position = new Vector3(Random.Range(-11, 10), 1, Random.Range(-11, 9));
                collision.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            }
        }
    }
}
