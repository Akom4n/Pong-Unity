using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaController : MonoBehaviour
{

    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;

    public float velocidade = 5f;

    public float limitehorizontal = 12f;

    public AudioClip boing;

    public Transform transformCamera;

    public float delay = 2f;

    public bool jogoIniciado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Iniciando a bola com um delay[

        //Diminuindo o valor do delay
        delay = delay - Time.deltaTime;


        // Checando se chegou em 0 para a bola sair e iniciar o jogo
        if (delay <= 0 && jogoIniciado == false)
        {
            jogoIniciado = true;


            int direcao = UnityEngine.Random.Range(0, 4);


            if (direcao == 0)
            {
                minhaVelocidade.x = velocidade;
                minhaVelocidade.y = velocidade;
            }
            if (direcao == 1)
            {
                minhaVelocidade.x = -velocidade;
                minhaVelocidade.y = velocidade;
            }
            if (direcao == 2)
            {
                minhaVelocidade.x = -velocidade;
                minhaVelocidade.y = -velocidade;
            }
            else
            {
                minhaVelocidade.x = -velocidade;
                minhaVelocidade.y = velocidade;
            }

            meuRB.linearVelocity = minhaVelocidade;
        }

        
        //Checando se a bola saiu da tela
        if (transform.position.x < -limitehorizontal || transform.position.x > limitehorizontal)
        {
            //Recarregando minha cena
            SceneManager.LoadScene(0);
        }
        
    }

    //Criando o meu evento de colisão

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(boing, transformCamera.position);
    }
}
