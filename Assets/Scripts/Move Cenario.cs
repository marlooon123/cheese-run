using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCenario : MonoBehaviour
{
    public Rigidbody2D cenario;
    [SerializeField] public float aceleracao = 5.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direcao = transform.up * aceleracao;            //Vector3 direcao = new Vector3 (0.0f, 1.0f * aceleracao, 0.0f);
            cenario.AddForce(direcao, ForceMode2D.Force);
    }
}
