using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Jobs;
using UnityEngine.UIElements;

public class RaqueteController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Vector3 minhaPosicao;
    private float meuY;
    public float velocidade = 5f;
    public float meuLimite = 3.5f;

    public bool player1;


    //Var para checar se ele vai ser automatico
    public bool automatico = false;

    //Pegando a posição da bola
    public Transform transformBola;


    void Start()
    {
        minhaPosicao =  transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        minhaPosicao.y = meuY;

        transform.position = minhaPosicao;

        float deltavelocidade = velocidade * Time.deltaTime;

        //Se o automatico não é true
        if (!automatico)
        {
            if (player1) 
            { 
                if (Input.GetKey(KeyCode.W))
                {
                    meuY = meuY + deltavelocidade;
                }

                if (Input.GetKey(KeyCode.S))
                {
                    meuY = meuY - deltavelocidade;
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    meuY = meuY + deltavelocidade;
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    meuY = meuY - deltavelocidade;
                }
            }
        }
        else
        {
            meuY = Mathf.Lerp(meuY, transformBola.position.y, 0.05f);
        }


        if (meuY < -meuLimite)
        {
            meuY = -meuLimite;
        }
        if (meuY > meuLimite)
        {
            meuY = meuLimite;
        }

    }
}
