using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotación : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime,0f);
    }
}
