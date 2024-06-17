using UnityEngine;
using Vuforia;

public class LookToCamera : MonoBehaviour
{
    private Camera vuforiaCamera;

    private void Start()
    {
        // Buscar la cámara de Vuforia
        vuforiaCamera = VuforiaBehaviour.Instance.GetComponent<Camera>();
    }

    private void Update()
    {
        if (vuforiaCamera != null)
        {
            // Hacer que el objeto mire hacia la cámara de Vuforia
            transform.LookAt(vuforiaCamera.transform);

            // Ajustar la rotación para que mire correctamente (opcional)
        }
    }
}
