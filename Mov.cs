using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    // Variaveis
    public float spd; // Variavel da velocidade.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movimento(); // Chama o void Movimento()
        VirarLado(); // Chama o void VirarLado()
    }

    void Movimento() // Movimenta o jogador
    {
        float mx = Input.GetAxis("Horizontal"); // Colocar os dados do input axis horizontal dentro da variavel mx
        Vector2 movement = new Vector2(mx, 0); // cria um vector2 chamado movement com os dados de (mx, 0)
        transform.Translate(movement * spd * Time.deltaTime); // muda a posição do jogador de acordo com movemente * spd * time.deltatime
    }
    void VirarLado() // Vira o lado do sprite
    {
        if(Input.GetKeyDown(KeyCode.D)) // Verifica se clicou a tecla D
        {
            transform.localScale = new Vector2(-1, 0); // Muda a escala para -1
        }
        if(Input.GetKeyDown(KeyCode.A)) // Verifica se clicou a tecla A
        {
            transform.localScale = new Vector2(1, 0); // Muda a escala para 1
        }
    }
}
