using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float movementEjeX;
    public float movementEjeY;
    public float movementEjeZ;
    public float fastmovement = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    // transform.Translate(10f, 0f, 2f);
    // x y z
    // y 0
    // x mas 10
    // z mas 2 
    // Update is called once per frame
    void Update()
    {
        //con un menos alado del imput se transforma

        movementEjeX = Input.GetAxis("Vertical") * Time.deltaTime * fastmovement;

        movementEjeZ = - Input.GetAxis("Horizontal") * Time.deltaTime * fastmovement;

        transform.Translate(movementEjeX, movementEjeY, movementEjeZ);
    }
}
