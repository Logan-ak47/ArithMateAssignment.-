using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static JsonSceneExport;
using UnityEngine.SceneManagement;
using System.IO;

public class ImportJsonSceneLoad : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject capsulePrefab;
    public void ImportSceneFromJson()
    {
        string jsonFileName = Application.dataPath +"sceneData.json";
        string json = File.ReadAllText(jsonFileName);
       
        SceneData sceneData = JsonUtility.FromJson<SceneData>(json);

        // Create a new scene for importing
        Scene newScene = SceneManager.CreateScene("ImportedScene");
        SceneManager.SetActiveScene(newScene);

        // Spawn objects in the new scene based on the imported data
        SpawnObjectsInImportedScene(sceneData);
    }

    private void SpawnObjectsInImportedScene(SceneData sceneData)
    {
        foreach (GameObjectData primitiveData in sceneData.objects)
        {
            GameObject prefab = GetPrefab(primitiveData.name);
        
            if (prefab != null)
            {
                Instantiate(prefab, primitiveData.position, Quaternion.identity);
            }
        }
    }

    private GameObject GetPrefab(string name)
    {
        switch (name)
        {
            case "Cube":
                return cubePrefab;
            case "Sphere":
                return spherePrefab;
            case "Capsule":
                return capsulePrefab;
            default:
                return null;
        }
    }
}
