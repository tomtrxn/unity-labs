using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj; // This can be private with SerializeField to expose in the inspector

    void Start()
    {
        Application.targetFrameRate = 60;


        // Instantiate redObj at (0, 0, 0) with no rotation
        Instantiate(redObj, Vector3.zero, Quaternion.identity);

        // Instantiate blueObj at (-2, 0, 0) with no rotation
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
