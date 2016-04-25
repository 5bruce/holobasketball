using UnityEngine;
using System.Collections;
using UnityEngine.VR.WSA.Input;

public class GestureCommands : MonoBehaviour
{
    private GestureRecognizer recognizer;

    public Rigidbody prefab;
    public float speed = 10.0f;

    // Use this for initialization
    void Start()
    {
        recognizer = new GestureRecognizer();
        recognizer.SetRecognizableGestures(GestureSettings.Tap);
        recognizer.TappedEvent += Recognizer_TappedEvent;
        recognizer.StartCapturingGestures();
    }

    private void Recognizer_TappedEvent(InteractionSourceKind source, int tapCount, Ray headRay)
    {
        ThrowNewBall();
    }

    private void ThrowNewBall()
    {
        var ball = (Rigidbody)Instantiate(prefab, transform.position, transform.rotation);
        ball.velocity = (transform.forward + transform.up * 0.8f) * speed;
    }


    public void OnDestroy()
    {
        if (recognizer != null) {
            recognizer.TappedEvent -= Recognizer_TappedEvent;
        }
    }
}
