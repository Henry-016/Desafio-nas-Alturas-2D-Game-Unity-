using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake(float duracao, float magnitude)
    {
        Vector3 posicaoOriginal = transform.localPosition;
        float tempoPassado = 0.0f;

        while (tempoPassado < duracao)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, posicaoOriginal.z);
            tempoPassado += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = posicaoOriginal;
    }
}
