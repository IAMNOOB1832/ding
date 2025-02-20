using UnityEngine;
using UnityEngine.XR;

public class MovingVR : MonoBehaviour
{
    public float speed = 2.0f; // De snelheid van de beweging
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Beweeg de speler altijd vooruit in de richting van de headset
        Vector3 move = transform.forward * speed * Time.deltaTime;
        characterController.Move(move);
    }
}
