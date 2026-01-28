using System.Collections;
using UnityEngine;

public class ControleDoComputador : MonoBehaviour
{
    private Aviao aviao;

    [SerializeField] private float intervalo;

    private void Start()
    {
        aviao = GetComponent<Aviao>();
        StartCoroutine(Impulsionar());
    }

    private IEnumerator Impulsionar()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalo);
            aviao.DarImpulso();
        }
    }
}
