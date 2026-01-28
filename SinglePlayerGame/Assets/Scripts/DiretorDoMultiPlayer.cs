using UnityEngine;

public class DiretorDoMultiPlayer : Diretor
{
    [SerializeField] private int pontosParaReviver = 5;

    private Jogador[] jogadores;
    private InterfaceInativa interfaceInativo;

    private bool alguemMorto;
    private int pontosDesdeAMorte;

    protected override void Start()
    {
        base.Start();
        jogadores = FindObjectsByType<Jogador>(FindObjectsSortMode.None);
        interfaceInativo = GameObject.FindAnyObjectByType<InterfaceInativa>();
    }

    public override void ReiniciarJogo()
    {
        base.ReiniciarJogo();
        ReviverJogadores();
    }
    public void ReviverSePrecisar()
    {
        if (alguemMorto)
        {
            pontosDesdeAMorte += 1;
            interfaceInativo.AtualizarTexto(pontosParaReviver - pontosDesdeAMorte);
            if (pontosDesdeAMorte >= pontosParaReviver)
            {
                interfaceInativo.Ocultar();
                ReviverJogadores();
            }
        }
    }

    public void AvisarQueAlguemMorreu(Camera cameraDoJogadorMorto)
    {
        if (alguemMorto)
        {
            interfaceInativo.Ocultar();
            FinalizarJogo();
        }

        else
        {
            alguemMorto = true;
            pontosDesdeAMorte = 0;
            interfaceInativo.AtualizarTexto(pontosParaReviver);
            interfaceInativo.Mostrar(cameraDoJogadorMorto);
        }   
    }

    private void ReviverJogadores()
    {

        alguemMorto = false;

        foreach (var jogador in jogadores)
        {
            jogador.Ativar();
        }
    }
}
