using UnityEngine;
using UnityEngine.InputSystem;

public class MovementDemo : MonoBehaviour
{
    Vector2 movement;

    public float playerSpeed;

    // Update is called once per frame
    void Update()
    {
        //forward 50%
        //Left/Right 20%
        //Back 10%

        float randValue = Random.value;

        if(randValue <= .5 )
        {
            movement = Vector2.up;
        }
        else if(randValue <= (.5 + .2))
        {
            movement = Vector2.left;
        }
        else if (randValue <= (.5 + .2 + .2))
        {
            movement = Vector2.right;
        }
        else
        {
            movement = Vector2.down;
        }

        //movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        transform.Translate(playerSpeed * movement * Time.deltaTime);
    }

    public void OnPlayerMove(InputAction.CallbackContext context)
    {
        //movement = context.ReadValue<Vector2>();
    }
}
