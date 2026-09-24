using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Vector2 movement;

    public float playerSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        //movement.x = Random.Range(-1f, 1f);
        //movement.y = Random.Range(-1f, 1f);


        transform.Translate(movement * Time.fixedDeltaTime * playerSpeed);
    }

    public void OnPlayerMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();

        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.gainsboro;

        //Gizmos.DrawWireSphere(transform.position, playerSpeed);

        Gizmos.DrawRay(transform.position, movement * playerSpeed);
    }
}
