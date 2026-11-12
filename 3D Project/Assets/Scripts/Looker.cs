using UnityEngine;
using UnityEngine.InputSystem;

public class Looker : MonoBehaviour
{
    public float lookSpeed = 30f;

    public Camera playerCam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OnPlayerLook(InputAction.CallbackContext context)
    {
        Vector3 input = context.ReadValue<Vector2>() * Time.deltaTime * lookSpeed;

        transform.rotation = transform.rotation * Quaternion.Euler(0f, input.x, 0f);

        playerCam.transform.Rotate(input.y, 0f, 0f);
    }
}
