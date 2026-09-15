using UnityEngine;
using TMPro;

public class CambiarFuente : MonoBehaviour
{
    [SerializeField] private TMP_Text textoTarget;
    [SerializeField] private TMP_FontAsset[] fuentes;

    private int indiceActual = 0;

    public void CambiaFuentes()
    {
        if (fuentes == null || fuentes.Length == 0) return;

        indiceActual = (indiceActual + 1) % fuentes.Length;
        textoTarget.font = fuentes[indiceActual];
    }
}