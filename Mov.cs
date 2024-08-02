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
        Movimento();
        VirarLado();
    }

    void Movimento() // Movimenta o jogador
    {
        float mx = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(mx, 0);
        transform.Translate(movement * spd * Time.deltaTime);
    }
    void VirarLado()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector2(-1, 0);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector2(1, 0);
        }
    }
}
