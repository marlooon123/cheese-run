using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCenario : MonoBehaviour
{
    [SerializeField] public float aceleracao = 5.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
         transform.position = transform.position + new Vector3(0.0f,  aceleracao * Time.deltaTime, 0.0f);    
    }
}
