using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    // Variaveis
    public float spd; // Variavel da velocidade.
    private Rigidbody2D rb; // Variavel do Rigidbody
    public float JumpForce; // Variavel da força do pulo
    private bool isGrounded; // Variavel para verificar se esta encostado no chao

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento(); // Chama o void Movimento()
        VirarLado(); // Chama o void VirarLado()
        Jump(); // Chama o void Pulo()
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
            transform.localScale = new Vector3(-1, 1, 0); // Muda a escala para -1
        }
        if(Input.GetKeyDown(KeyCode.A)) // Verifica se clicou a tecla A
        {
            transform.localScale = new Vector3(1, 1, 0); // Muda a escala para 1
        }
    }
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) // Verifica se apertou a tecla espaço e esta no chao
        {
            rb.velocity = new Vector2(0.0f, JumpForce); // Faz o player pular
        }
    } 
    void OnCollisionEnter2D(Collision2D collision) // Verifica se entrou em colisão
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground")) // Verifica se o objeto que entrou em colisao tem o layer "Ground"
        {
            isGrounded = true; // Coloca a variavel isGrounded como verdadeiro
        }
    }
    void OnCollisionExit2D(Collision2D collision) // Verifica se saiu da colisão
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground")) // Verifica se o objeto que entrou em colisao tem o layer "Ground"
        {
            isGrounded = false; // Coloca a variavel isGrounded como falso
        }
    }
}
