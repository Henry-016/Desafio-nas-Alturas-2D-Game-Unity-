using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField] private AudioSource trilhaSonora;

    [SerializeField] private ControleDeDificuldade controleDeDificuldade;

    private Aviao aviao;
    private Pontuacao pontuacao;
    private InterfaceGameOver interfaceGameOver;

    protected virtual void Start()
    {
        aviao = GameObject.FindAnyObjectByType<Aviao>();
        pontuacao = GameObject.FindAnyObjectByType<Pontuacao>();
        interfaceGameOver = GameObject.FindAnyObjectByType<InterfaceGameOver>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        trilhaSonora.Stop();
        pontuacao.SalvarRecorde();
        interfaceGameOver.MostrarInterface();
    }

    public virtual void ReiniciarJogo()
    {
        interfaceGameOver.EsconderInterface();
        Time.timeScale = 1;
        aviao.Reiniciar();
        DestruirObstaculos();
        controleDeDificuldade.ReiniciarDificuldade();
        pontuacao.ReiniciarPontos();
        trilhaSonora.Play();
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsByType<Obstaculo>(FindObjectsSortMode.None);

        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
