using UnityEngine;
using Vuforia;

public class CameraFollowScript : MonoBehaviour
{
    private Camera vuforiaCam;

    // Start is called before the first frame update
    void Start()
    {
        vuforiaCam = VuforiaBehaviour.Instance.GetComponent<Camera>();

        if (vuforiaCam == null)
        {
            Debug.LogError("No se encontro la camara");
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (vuforiaCam != null)
        {
            // Hace que el objeto mire hacia la cámara de Vuforia
            transform.LookAt(vuforiaCam.transform);

            // Añade 180 grados al eje Y
            transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + 180, 0);
        }

        // Rotar el objeto alrededor del eje Y
        transform.Rotate(Vector3.up, 0.5f * Time.deltaTime);
    }
}
