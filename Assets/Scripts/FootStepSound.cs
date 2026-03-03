using UnityEngine;

public class FootStepSound : MonoBehaviour
{
    public AudioSource footstepAudio;
    public float stepDelay = 0.5f;

    private float stepTimer;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        bool isMoving = h != 0 || v != 0;

        if (isMoving)
        {
            stepTimer -= Time.deltaTime;

            if (stepTimer <= 0)
            {
                footstepAudio.Play();
                stepTimer = stepDelay;
            }
        }
        else
        {
            stepTimer = 0;
        }
    }
}
