using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonSceneExport : MonoBehaviour
{
    public void ExportSceneToJson()
    {
        SceneData sceneData = new SceneData();

        GameObject[] objectsInScene = GameObject.FindGameObjectsWithTag("Primitive");
        foreach (GameObject obj in objectsInScene)
        {
            GameObjectData gameObjectData = new GameObjectData();
            gameObjectData.name = obj.name.Substring(0, obj.name.IndexOf("("));
            gameObjectData.position = obj.transform.position;
            sceneData.objects.Add(gameObjectData);
        }

        string json = JsonUtility.ToJson(sceneData);
       
        File.WriteAllText(Application.dataPath+"sceneData.json", json);
    }



}
