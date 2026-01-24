using System;
using UnityEngine;
using UnityEngine.Rendering;

public class Carrosel : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhada velocidade;

    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;

    private void Awake()
    {
        posicaoInicial = transform.position;
        float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = transform.localScale.x;
        tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }

    private void Update()
    {
        float deslocamento = Mathf.Repeat(velocidade.valor * Time.time, tamanhoRealDaImagem);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
