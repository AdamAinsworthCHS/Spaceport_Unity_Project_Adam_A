using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public static float speed = 5.0f;
    public float turnSpeed = 40.0f;
    private float forwardInput;
    private float rotationalInput;
    private float pivotInput;

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical") * -1;
        rotationalInput = Input.GetAxis("Mouse X") * 15;
        pivotInput = Input.GetAxis("Mouse Y") * 15;

        // Move the ship forward based on vertical input
        transform.Translate(Vector3.up * Time.deltaTime * speed * forwardInput);

        // Rotates the ship based on mouse input
        transform.Rotate(Vector3.forward, turnSpeed * rotationalInput * Time.deltaTime);
        transform.Rotate(Vector3.left, turnSpeed * pivotInput * Time.deltaTime);
    }
}
