using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField]
    private float forca = 10f;

    private Rigidbody2D rigidBody;

    private Diretor diretor;
    private Vector3 posicaoInicial;

    // Start is called before the first frame update
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<Diretor>();
        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("clicou");
            Impulsionar();
        }
    }

    private void Impulsionar()
    {
        rigidBody.velocity = Vector2.zero;
        rigidBody.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidBody.simulated = false;
        diretor.FinalizarJogo();
    }

    public void Reiniciar()
    {
        transform.position = posicaoInicial;
        rigidBody.simulated = true;
    }
}
