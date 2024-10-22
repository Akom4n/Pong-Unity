using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Jobs;
using UnityEngine.UIElements;

public class RaqueteController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Vector3 minhaPosicao;
    public float meuY;
    public float velocidade = 5f;
    public float meuLimite = 3.5f;

    void Start()
    {
        minhaPosicao =  transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        minhaPosicao.y = meuY;

        transform.position = minhaPosicao;

        if (Input.GetKey(KeyCode.UpArrow) && meuY < meuLimite)
        {
                meuY = meuY + velocidade * Time.deltaTime;
        }
         
        if (Input.GetKey(KeyCode.DownArrow) && meuY > -meuLimite)
        {
            meuY = meuY - velocidade * Time.deltaTime;
        }
        
        
        
    }
}
