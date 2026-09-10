using UnityEngine;

public class AbrirEnlace : MonoBehaviour
{
    [SerializeField] private string url = "https://www.unity.com";

    public void AbrirURL()
    {
        Application.OpenURL(url);
    }
}
