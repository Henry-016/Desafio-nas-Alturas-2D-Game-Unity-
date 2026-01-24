using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhada velocidade;

    [SerializeField]
    private float variacaoDaPosicaoY;

    private Vector3 posicaoDoAviao;

    private bool pontuei;
    
    private Pontuacao pontuacao;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Start()
    {
        posicaoDoAviao = GameObject.FindAnyObjectByType<Aviao>().transform.position;
        pontuacao = GameObject.FindAnyObjectByType<Pontuacao>();
    }

    private void Update()
    {
        this.transform.Translate(Vector3.left * (velocidade.valor * Time.deltaTime));

        if (transform.position.x < posicaoDoAviao.x && !pontuei)
        {
            pontuei = true;
            pontuacao.AdicionarPontos();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DestruidorDeObstaculos"))
        {
            Destruir();
        }
    }

    public void Destruir()
    {
        GameObject.Destroy(gameObject);
    }
        
}
