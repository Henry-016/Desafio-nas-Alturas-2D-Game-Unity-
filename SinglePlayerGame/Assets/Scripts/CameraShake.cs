using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    private float limiteMinY = -2f;
    private float limiteMaxY = 5f;

    public IEnumerator Shake(float duracao, float magnitude)
    {
        Vector3 posicaoOriginal = transform.localPosition;
        float tempoPassado = 0.0f;

        while (tempoPassado < duracao)
        {
            float offsetX = Random.Range(-1f, 1f) * magnitude;
            float offsetY = Random.Range(-1f, 1f) * magnitude;

            float novoX = posicaoOriginal.x + offsetX;
            float novoY = posicaoOriginal.y + offsetY;

            novoY = Mathf.Clamp(novoY, limiteMinY, limiteMaxY);

            transform.localPosition = new Vector3(novoX, novoY, posicaoOriginal.z);

            tempoPassado += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = posicaoOriginal;
    }
}