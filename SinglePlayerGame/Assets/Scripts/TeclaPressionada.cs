using UnityEngine;
using UnityEngine.Events;

public class TeclaPressionada : MonoBehaviour
{
    [SerializeField] private KeyCode tecla;

    [SerializeField] private UnityEvent aoSerPressionada;

    private void Update()
    {
        if(Input.GetKeyDown(tecla))
        {
            aoSerPressionada.Invoke();
        }
    }
}
