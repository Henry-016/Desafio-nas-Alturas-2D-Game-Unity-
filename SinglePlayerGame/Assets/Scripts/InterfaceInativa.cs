using UnityEngine;
using UnityEngine.UI;

public class InterfaceInativa : MonoBehaviour
{
    [SerializeField] private GameObject fundo;
    [SerializeField] private Text texto;

    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void AtualizarTexto(int pontosParaReviver)
    {
        texto.text = pontosParaReviver.ToString();
    }

    public void Mostrar(Camera cameraDoJogadorMorto)
    {
        fundo.SetActive(true);
        canvas.worldCamera = cameraDoJogadorMorto;
    }

    public void Ocultar()
    {
        fundo.SetActive(false);
    }
}
