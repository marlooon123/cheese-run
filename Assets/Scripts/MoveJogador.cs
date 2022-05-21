using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveJogador : MonoBehaviour
{
    public float Velocidade = 10;
    private float eixoX;
    private float eixoZ;
    
    direcao = new Vector3(eixoX, 0, eixoZ);
    
    void Update()
    {
        //Inputs do Jogador - Guardando teclas apertadas
        eixoX = Input.GetAxis("Horizontal");
        eixoZ = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {   //Movimentacao do Jogador por segundo
        GetComponent<Rigidbody>().MovePosition
            (GetComponent<Rigidbody>().position +
            (direcao * Velocidade * Time.deltaTime));

    }
}
