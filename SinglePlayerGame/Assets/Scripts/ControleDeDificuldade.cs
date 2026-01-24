using UnityEngine;
using UnityEngine.Rendering;

public class ControleDeDificuldade : MonoBehaviour
{
    [SerializeField] [Range(1, 600)]
    private float tempoParaDificuldadeMaxima = 60;

    private float tempoPassado;
    public float dificuldade { get; private set; }

    void Update()
    {
        tempoPassado += Time.deltaTime;
        dificuldade = tempoPassado / tempoParaDificuldadeMaxima;
        dificuldade = Mathf.Min(1, dificuldade);
    }

    public void ReiniciarDificuldade()
    {
        tempoPassado = 0;
        dificuldade = 0;
    }
}
