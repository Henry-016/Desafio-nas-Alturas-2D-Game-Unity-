using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;

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
