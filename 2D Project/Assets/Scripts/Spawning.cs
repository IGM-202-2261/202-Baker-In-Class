using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject prefab;

    public GameObject clone;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Spawn();   
    }

    // Update is called once per frame
    void Update()
    {
        if(clone == null)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        clone = Instantiate(prefab);
    }
}
