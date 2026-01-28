using UnityEngine;
using UnityEngine.Events;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;

    [SerializeField] private float forca;
    [SerializeField] private UnityEvent aoBater;
    [SerializeField] private UnityEvent aoPassarPeloObstaculo;

    private Vector3 posicaoInicial;
    private Animator animacao;
    private AudioSource audioQuedaDoAviao;
    private bool deveImpulsionar;

    private void Awake()
    {
        audioQuedaDoAviao = GetComponent<AudioSource>();
        fisica = GetComponent<Rigidbody2D>();
        animacao = GetComponent<Animator>();
        posicaoInicial = transform.position;
    }

    private void Update()
    {
        animacao.SetFloat("VelocidadeY", fisica.linearVelocity.y);
    }

    private void FixedUpdate()
    {
        if (deveImpulsionar)
        {
            this.Impulsionar();
        }
    }

    public void DarImpulso()
    {
        deveImpulsionar = true;
    }

    private void Impulsionar()
    {
        fisica.linearVelocity = Vector2.zero;
        fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
        deveImpulsionar = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioQuedaDoAviao.Play();
        fisica.simulated = false;
        aoBater.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        aoPassarPeloObstaculo.Invoke();
    }

    public void Reiniciar()
    {
        audioQuedaDoAviao.Stop();
        transform.position = posicaoInicial;
        fisica.simulated = true;
    }
}
