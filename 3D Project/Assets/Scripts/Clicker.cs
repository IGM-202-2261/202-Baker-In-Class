using UnityEngine;
using UnityEngine.InputSystem;

public class Clicker : MonoBehaviour
{
    public LayerMask hitLayer;

    public void OnFire(InputAction.CallbackContext context)
    {
        Ray fireRay = new Ray(transform.position, transform.forward);

        RaycastHit hit;

        if(context.performed)
        {
            if(Physics.Raycast(fireRay, out hit, Mathf.Infinity, hitLayer))
            {
                hit.transform.localScale = new Vector3(Random.Range(0.5f, 2f), Random.Range(0.5f, 2f), Random.Range(0.5f, 2f));
            }
        }
    }
}
