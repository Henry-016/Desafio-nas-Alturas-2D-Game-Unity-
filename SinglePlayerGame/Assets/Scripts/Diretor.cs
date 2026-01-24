using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField] private AudioSource trilhaSonora;

    [SerializeField] private ControleDeDificuldade controleDeDificuldade;

    [SerializeField] private CameraShake cameraShake;

    private Aviao aviao;
    private Pontuacao pontuacao;
    private InterfaceGameOver interfaceGameOver;

    private void Start()
    {
        aviao = GameObject.FindAnyObjectByType<Aviao>();
        pontuacao = GameObject.FindAnyObjectByType<Pontuacao>();
        interfaceGameOver = GameObject.FindAnyObjectByType<InterfaceGameOver>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        trilhaSonora.Stop();
        StartCoroutine(cameraShake.Shake(0.03f, 0.14f));
        pontuacao.SalvarRecorde();
        interfaceGameOver.MostrarInterface();
    }

    public void ReiniciarJogo()
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
