using UnityEngine;
using UnityEngine.Events;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] private VariavelCompartilhada velocidade;

    [SerializeField] private float variacaoDaPosicaoY;
    
    private Pontuacao pontuacao;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Start()
    {
        pontuacao = GameObject.FindAnyObjectByType<Pontuacao>();
    }

    private void Update()
    {
        this.transform.Translate(Vector3.left * (velocidade.valor * Time.deltaTime));
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
