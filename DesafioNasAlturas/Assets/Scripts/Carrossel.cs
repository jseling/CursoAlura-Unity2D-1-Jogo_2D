using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 5f;

    private Vector3 posicaoInicial;

    private float tamanhoImagem;


    // Start is called before the first frame update
    void Awake()
    {
        posicaoInicial = transform.position;
        tamanhoImagem = GetComponent<SpriteRenderer>().size.x * transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < posicaoInicial.x - tamanhoImagem)
        {
            transform.position = posicaoInicial;
        }

        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
