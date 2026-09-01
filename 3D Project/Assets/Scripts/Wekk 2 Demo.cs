using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Wekk2Demo : MonoBehaviour
{
    public int favNuber = 34;

    [SerializeField]
    string dumm;

    public Vector3 test;

    public GameObject testingGO;

    public Camera camera;

    public GameObject snowThingPrefab;

    public List<GameObject> clones = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        //Debug.Log(favNuber);

        //Destroy(camera.gameObject);

        clones.Add( Instantiate(snowThingPrefab) );

        clones[clones.Count - 1].GetComponent<Rigidbody>().mass = 500;
        //Physics.gravity = new Vector3(0, -5, 0);
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
