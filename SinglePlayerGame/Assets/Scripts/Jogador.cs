using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Carrosel[] cenario;
    private GeradorDeObstaculos geradorDeObstaculos;
    private Aviao aviao;

    private bool estouMorto;

    void Start()
    {
        cenario = GetComponentsInChildren<Carrosel>();
        geradorDeObstaculos = GetComponentInChildren<GeradorDeObstaculos>();
        aviao = GetComponentInChildren<Aviao>();
    }

    public void Desativar()
    {
        estouMorto = true;

        geradorDeObstaculos.Parar();

        foreach (var carrosel in cenario)
        {
            carrosel.enabled = false;
        }
    }

    public void Ativar()
    {
        if (estouMorto)
        {
            aviao.Reiniciar();
            geradorDeObstaculos.Recomecar();

            foreach (var carrosel in cenario)
            {
                carrosel.enabled = true;
            }

            estouMorto = false;
        }
    }
}
