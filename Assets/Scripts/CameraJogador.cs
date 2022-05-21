using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraJogador : MonoBehaviour
{
    public GameObject Jogador;

    private Vector3 direcao;
    void Start()
    {
        direcao = transform.position - Jogador.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Jogador.transform.position + direcao;
    }
}
