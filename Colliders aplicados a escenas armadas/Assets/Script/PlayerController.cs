using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 direction = Vector3.zero;
    CharacterController cc;
    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }
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
        cc.Move(direction.normalized * speed * Time.deltaTime);
        //El CharacterController tambi�n tiene un collider? porque al a�adir el componenete tambi�n aparece unas lineas verdes.
        //Con el CharacterController parece que tampoco le afecta la gravedad cuando le pongo un rigidBody, ���qu� est� pasando con el character controller???
        //Y con characterController no funciona los m�todos de collisiones -_- .Creo que voy a desactivar CharacterController y hacer el movimiento con transform
    }
}
