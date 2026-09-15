using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public GameObject clone;

    int spawnCount = 1000;

    public Vector2 spawnMean;
    public float spawnSTD;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < spawnCount; i++)
        {
            Vector3 spawnPos = new Vector2(Gaussian(spawnMean.x, spawnSTD), Gaussian(spawnMean.y, spawnSTD));

            clone = Instantiate(prefab, spawnPos, Quaternion.identity);
        }
        
    }

    float Gaussian(float mean, float stdDev)
    {
        float val1 = Random.Range(0f, 1f);
        float val2 = Random.Range(0f, 1f);
        float gaussValue =
                 Mathf.Sqrt(-2.0f * Mathf.Log(val1)) *
                 Mathf.Sin(2.0f * Mathf.PI * val2);
        return mean + stdDev * gaussValue;
    }

}
