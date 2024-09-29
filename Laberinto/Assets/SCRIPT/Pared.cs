using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{
    [SerializeField]
    Material materialpordefecto;

    [SerializeField]
    Material materialParedTocada;

    bool paredNaranja = false;

    float tiempoenNaranja = 4f;

    private void Update()
    {
        if (paredNaranja == true)
        {
            tiempoenNaranja = tiempoenNaranja - Time.deltaTime;
            if (tiempoenNaranja < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialpordefecto;
                paredNaranja = false;
                tiempoenNaranja = 4f;

            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
           
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;
            paredNaranja = true;
        }
    }

}
