using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveJogador : MonoBehaviour
{
    [SerializeField] public float aceleracao = 10.0f;
    public float velocidadeMax = 50.0f;
    public Rigidbody2D jogadorRb;

    private bool Vivo = true;

    public GameObject loseTextObject;
    public GameObject winTextObject;
    private int count;

    void Start()
    {
        loseTextObject.SetActive(false);
        winTextObject.SetActive(false);
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Vector3 direcao = Vector3.left * aceleracao;            //Vector3 direcao = new Vector3 (0.0f, 1.0f * aceleracao, 0.0f);
            jogadorRb.AddForce(direcao, ForceMode2D.Force);         //Adiciona aceleracao no jogadorRb
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

    bool marca = false;
    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Vitoria") & marca == false)
        {
            winTextObject.SetActive(true);
            marca = true;
        }
        if(other.gameObject.CompareTag("Derrota") & marca == false)
        {
            loseTextObject.SetActive(true);
            marca = true;
        }
    }
    
}
