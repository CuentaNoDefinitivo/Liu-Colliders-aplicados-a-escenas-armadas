using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    float time = 2.5f;
    bool reduced = false;


    private void OnTriggerExit(Collider other)
    {
        if (time >= 2.5f && reduced == false && other.gameObject.CompareTag("Player"))
        {
            //reducir el tamaño
            other.transform.localScale *= 0.5f;


            //resetear todas las condiciones
            time = 0;
            reduced = true;
        }
        else if (time >= 2.5f && reduced == true && other.gameObject.CompareTag("Player"))
        {
            //aumentar el tamaño
            other.transform.localScale *= 2f;


            //resetear todas las condiciones
            time = 0;
            reduced = false;
        }
    }

    
    void Update()
    {
        //empezar a contar tiempo una vez que lo ha resetado a cero
        if (time < 2.5f)
        {
            time += Time.deltaTime;
        }
    }
   
    //porqué cuando cruzo el portal, el player empieza a girar? ya he freezeado los ejes x z en el rigidBody,
    //cuando freezeo también el eje y se arregla, pero creo que hay que tener esta eje libre...
    //ahora que lo pruebo parece que no solo pasa con el portal, pasa con todo lo que se choca, ¡pero si ya está freezeado los ejes x z !
}
