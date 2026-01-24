using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemDeGameOver;

    [SerializeField]
    private Text valorRecorde;

    [SerializeField]
    private Image posicaoMedalha;

    [SerializeField]
    private Sprite medalhaOuro;

    [SerializeField]
    private Sprite medalhaPrata;

    [SerializeField]
    private Sprite medalhaBronze;

    private Pontuacao pontuacao;
    private int recorde;

    private void Start()
    {
        pontuacao = GameObject.FindAnyObjectByType<Pontuacao>();
    }
    private void AtualizarInterfaceGrafica()
    {
        recorde = PlayerPrefs.GetInt("recorde");
        valorRecorde.text = recorde.ToString();
        VerificarCorMedalha();
    }

    public void MostrarInterface()
    {
        AtualizarInterfaceGrafica();
        imagemDeGameOver.SetActive(true);
    }

    public void EsconderInterface()
    {
        imagemDeGameOver.SetActive(false);
    }

    private void VerificarCorMedalha()
    {
        if (pontuacao.Pontos >= recorde)
        {
            posicaoMedalha.sprite = medalhaOuro;
        }

        else if (pontuacao.Pontos > (recorde / 2))
        {
            posicaoMedalha.sprite = medalhaPrata;
        }

        else
        {
            posicaoMedalha.sprite = medalhaBronze;
        }
    }
}
