using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class MaoPiscando : MonoBehaviour
{
    private SpriteRenderer imagem;

    private void Awake()
    {
        imagem = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Desaparecer();
        }
    }

    private void Desaparecer()
    {
        imagem.enabled = false;
    }
}
