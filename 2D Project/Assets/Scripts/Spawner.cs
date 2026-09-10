using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public GameObject clone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clone = Instantiate(prefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (clone == null)
        {
            Start();
        }
    }
}
