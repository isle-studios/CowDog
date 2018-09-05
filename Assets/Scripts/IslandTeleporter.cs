using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandTeleporter : MonoBehaviour {

    public SceneTransition sceneChanger;
    public string SceneName;

    private void OnTriggerEnter(Collider other)
    {
        sceneChanger.GoToScene(SceneName);
    }
}
