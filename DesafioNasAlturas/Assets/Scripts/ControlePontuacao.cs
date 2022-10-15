using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlePontuacao : MonoBehaviour
{
    private int pontos;


    private Text textoPontuacao;

    private AudioSource audioPontuacao;

    private void Awake()
    {
        textoPontuacao = GetComponent<Text>();
        audioPontuacao = GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        pontos++;
        textoPontuacao.text = pontos.ToString();
        audioPontuacao.Play();
    }

    public void Reiniciar()
    {
        pontos = 0;
        textoPontuacao.text = pontos.ToString();
    }
}
