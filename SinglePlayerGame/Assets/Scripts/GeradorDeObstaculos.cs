using UnityEngine;
using UnityEngine.Rendering;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerarFacil;

    [SerializeField]
    private float tempoParaGerarDificil;

    [SerializeField]
    private GameObject manualDeInstrucoes;

    private ControleDeDificuldade controleDeDificuldade;

    private float cronometro;

    private bool parado = false;

    private void Awake()
    {
        cronometro = tempoParaGerarFacil;
    }

    private void Start()
    {
        controleDeDificuldade = GameObject.FindAnyObjectByType<ControleDeDificuldade>();
    }

    private void Update()
    {
        if(parado)
        {
            return;
        }

        cronometro -= Time.deltaTime;

        if(cronometro < 0)
        {
            GameObject.Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);
            cronometro = Mathf.Lerp(tempoParaGerarFacil, tempoParaGerarDificil, controleDeDificuldade.dificuldade);
        }
    }

    public void Parar()
    {
        parado = true;
    }

    public void Recomecar()
    {
        parado = false;
    }

}
