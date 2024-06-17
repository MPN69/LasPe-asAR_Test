using UnityEngine;

public class Forward : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 startPosition;
    public Transform init;

    private void Start()
    {
        // Guardar la posición inicial del objeto
        startPosition = init.localPosition;
    }

    private void FixedUpdate()
    {
        // Mover el objeto hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Cuando detecta una colisión, volver a la posición de origen
        transform.localPosition = startPosition;
    }
}
