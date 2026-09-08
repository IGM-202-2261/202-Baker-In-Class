using UnityEngine;
using UnityEngine.InputSystem;

public class InputTesting : MonoBehaviour
{
    public Vector2 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
        }

        if(Input.GetKey(KeyCode.F))
        {
            Debug.Log("Auto Fire");
        }*/

        Vector3 mousePos = Input.mousePosition;

        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;

        Debug.Log(mousePos);
    }

    public void OnPlayerJump()
    {
        Debug.Log("jump");
    }

    public void OnBetterJump(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("Better Jump");
        }
    }

    public void OnPlayerMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
}
