using TouchScript.Gestures.TransformGestures;
using UnityEngine;

public class HorizontalRotationScript : MonoBehaviour
{
    // Touchscript
    private TransformGesture transformGesture;

    // Vuforia
    private bool canRotate = true;

    private void FixedUpdate()
    {
        if (canRotate)
        {
            transform.Rotate(0, 0.3f, 0);
        }
    }

    public void StartRotation() => canRotate = true;

    public void StopRotation() => canRotate = false;

    private void OnEnable()
    {
        transformGesture = GetComponent<TransformGesture>();
        transformGesture.TransformCompleted += OnTransformCompleted;
        transformGesture.TransformStarted += OnTransformStarted;
        transformGesture.Transformed += OnTransformed;
    }

    private void OnDisable()
    {
        transformGesture.TransformCompleted -= OnTransformCompleted;
        transformGesture.TransformStarted -= OnTransformStarted;
        transformGesture.Transformed -= OnTransformed;

        transform.localScale = Vector3.one;
    }

    public void OnTransformStarted(object sender, System.EventArgs e)
    {
        canRotate = false;
    }

    public void OnTransformCompleted(object sender, System.EventArgs e)
    {
        canRotate = true;
    }

    private void OnTransformed(object sender, System.EventArgs e)
    {
        TransformGesture gesture = sender as TransformGesture;
        Vector3 deltapos = gesture.DeltaPosition;

        // Añade la rotación en el eje Y basado en el gesto
        transform.Rotate(0, -deltapos.x * 4f, 0);

        Debug.Log("Transformed: " + deltapos.x);
    }
}
