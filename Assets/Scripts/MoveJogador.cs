using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJogador : MonoBehaviour
{
    [SerializeField] public float aceleracao = 10.0f;
    public float velocidadeMax = 50.0f;
    public Rigidbody2D jogadorRb;

    private bool Vivo = true;


    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Vector3 direcao = Vector3.left * aceleracao;            //Vector3 direcao = new Vector3 (0.0f, 1.0f * aceleracao, 0.0f);
            jogadorRb.AddForce(direcao, ForceMode2D.Force);         //Adiciona aceleração no jogadorRb
        }
        if(Input.GetKey(KeyCode.D))
        {
            Vector3 direcao = Vector3.right * aceleracao;
            jogadorRb.AddForce(direcao, ForceMode2D.Force); 
        
        }
        if(jogadorRb.velocity.magnitude > velocidadeMax)
        {
            jogadorRb.velocity = Vector2.ClampMagnitude(jogadorRb.velocity, velocidadeMax);//velocidade atual com o limite de velocidade
        }


    }
    
}
