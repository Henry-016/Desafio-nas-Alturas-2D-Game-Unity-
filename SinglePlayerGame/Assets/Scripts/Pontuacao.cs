using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{
    [SerializeField] private Text textoPontuacao;

    [SerializeField] private UnityEvent aoPontuar;

    private AudioSource audioPontuacao;

    public int Pontos { get; private set; }

    private void Awake()
    {
        audioPontuacao = GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        Pontos += 1;
        textoPontuacao.text = Pontos.ToString();
        aoPontuar.Invoke();
        audioPontuacao.Play();
    }

    public void ReiniciarPontos()
    {
        Pontos = 0;
        textoPontuacao.text = Pontos.ToString();
    }
        
    public void SalvarRecorde()
    {
        int recordeAtual = PlayerPrefs.GetInt("recorde");

        if (Pontos > recordeAtual)
        {
            PlayerPrefs.SetInt("recorde", Pontos);
        }
    }
}
