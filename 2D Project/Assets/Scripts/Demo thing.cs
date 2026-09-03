using UnityEngine;

public class Demothing : MonoBehaviour
{

    public GameObject testing;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(testing.name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.otherCollider.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
