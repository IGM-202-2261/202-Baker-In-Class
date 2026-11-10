using UnityEngine;
using UnityEngine.InputSystem;

public class LookerDemo : MonoBehaviour
{
    public float turnSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayerRotate(InputAction.CallbackContext context)
    {
        Vector2 lookInput = context.ReadValue<Vector2>() * turnSpeed * Time.deltaTime;

        Quaternion newRot = Quaternion.Euler(lookInput.y, lookInput.x, 0f);

        //transform.rotation = transform.rotation * newRot;
        if (lookInput.x != 0f)
        {
            transform.Rotate(0f, lookInput.x * turnSpeed * Time.deltaTime, 0f);
        }

        if (lookInput.y != 0f)
        {
            //lookInput.y *= yLookInversion ? 1f : -1f;

            playerCam.transform.Rotate(lookInput.y * turnSpeed * Time.deltaTime, 0f, 0f);
        }
    }
}
