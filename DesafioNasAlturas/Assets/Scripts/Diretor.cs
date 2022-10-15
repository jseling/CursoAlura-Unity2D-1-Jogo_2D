using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    private Aviao aviao;
    private ControlePontuacao pontuacao;
    // Start is called before the first frame update
    private void Start()
    {
        aviao = GameObject.FindObjectOfType<Aviao>();
        pontuacao = GameObject.FindObjectOfType<ControlePontuacao>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        DestruirObstaculos();
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        aviao.Reiniciar();
        pontuacao.Reiniciar();
    }

    private void DestruirObstaculos()
    {
        ControlaObstaculo[] obstaculos = GameObject.FindObjectsOfType<ControlaObstaculo>();
        foreach(ControlaObstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
