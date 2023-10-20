using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static JsonSceneExport;

public class PrimitiveGameObjectSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject capsulePrefab;

    public void InstantiateCube()
    {
        Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);
    }

    public void InstantiateSphere()
    {
        Instantiate(spherePrefab, Vector3.zero, Quaternion.identity);
    }

    public void InstantiateCapsule()
    {
        Instantiate(capsulePrefab, Vector3.zero, Quaternion.identity);
    }


   
   
}
