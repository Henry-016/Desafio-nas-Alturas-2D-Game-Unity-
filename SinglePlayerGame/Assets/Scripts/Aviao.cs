using UnityEngine;
using UnityEngine.InputSystem;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;

    [SerializeField]
    private float forca;

    private Diretor diretor;
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

    private void Start()
    {
        diretor = GameObject.FindAnyObjectByType<Diretor>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            deveImpulsionar = true;
        }

        animacao.SetFloat("VelocidadeY", fisica.linearVelocity.y);
    }

    private void FixedUpdate()
    {
        if (deveImpulsionar == true)
        {
            this.Impulsionar();
        }
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
        diretor.FinalizarJogo();
    }

    public void Reiniciar()
    {
        audioQuedaDoAviao.Stop();
        transform.position = posicaoInicial;
        fisica.simulated = true;
    }
}
