using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Week2demo : MonoBehaviour
{
    public string myVar1;

    [SerializeField]
    int favNumber = 34;

    public GameObject lightGO;

    public Light p_Light;

    public Week2demo thing;

    public GameObject snowAxePref;

    public List<GameObject> clones = new List<GameObject>();



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightGO = gameObject;
    }

    private void Awake()
    {
        
    }

    public void Init()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(favNumber);

        lightGO.GetComponent<Light>().color = Random.ColorHSV();

        //p_Light.color = Random.ColorHSV();

        //Init();

        clones.Add(Instantiate(snowAxePref));
    }

    private void OnEnable()
    {
        
    }
}
