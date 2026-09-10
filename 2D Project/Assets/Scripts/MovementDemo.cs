using UnityEngine;
using UnityEngine.InputSystem;

public class MovementDemo : MonoBehaviour
{
    public Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement);
    }

    public void OnPlayerMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
}
