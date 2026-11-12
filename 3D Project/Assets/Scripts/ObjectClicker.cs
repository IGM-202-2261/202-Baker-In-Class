using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectClicker : MonoBehaviour
{
    public LayerMask hitLayer;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        RaycastHit hit;

        if(context.performed)
        {
            if(Physics.Raycast(new Ray(transform.position, transform.forward), out hit, Mathf.Infinity, hitLayer))
            {
                hit.transform.Translate(0f, 1, 0);
            }
        }
    }
}
