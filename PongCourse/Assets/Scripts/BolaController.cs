using System;
using Unity.Mathematics;
using UnityEngine;

public class BolaController : MonoBehaviour
{

    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;

    public float velocidade = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        int direcao = UnityEngine.Random.Range(0, 4);


        if(direcao == 0)
        {
           minhaVelocidade.x = velocidade;
           minhaVelocidade.y = velocidade;
        }
        if(direcao == 1)
        {
           minhaVelocidade.x = -velocidade;
           minhaVelocidade.y = velocidade;
        }
        if(direcao == 2)
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
