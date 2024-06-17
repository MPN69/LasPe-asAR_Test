using UnityEngine;

public class OriginScript : MonoBehaviour
{
    public Transform parentObject;

    void Update()
    {
        // Detectar si se ha tocado la pantalla
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Verificar si el toque es un toque rápido (tap)
            if (touch.phase == TouchPhase.Ended)
            {
                // Volver a la posición local original dentro del objeto padre
                transform.position = parentObject.transform.position;
            }
        }

        // Detectar clic con el ratón (para pruebas en el editor)
        if (Input.GetMouseButtonUp(0))
        {
            // Volver a la posición local original dentro del objeto padre
            transform.position = parentObject.transform.position;
        }
    }
}
