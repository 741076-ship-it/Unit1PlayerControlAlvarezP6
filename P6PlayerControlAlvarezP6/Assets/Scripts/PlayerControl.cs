using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    public Camera mainCamera; 
    public Camera hoodCamera; 
    public KeyCode switchKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on verticle imput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled; 
            hoodCamera.enabled = !hoodCamera.enabled; 
        }
         
    }
}
