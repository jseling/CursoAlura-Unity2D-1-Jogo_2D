using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;

    private float cronometro;

    [SerializeField]
    private GameObject obstaculoPrefab;

    // Start is called before the first frame update
    void Awake()
    {
        cronometro = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cronometro -= Time.deltaTime;
        if(cronometro <= 0)
        {
            Instantiate(obstaculoPrefab, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}
