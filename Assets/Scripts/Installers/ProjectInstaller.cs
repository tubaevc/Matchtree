using System.Collections;
using System.Collections.Generic;
using Events;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class ProjectInstaller : MonoInstaller<ProjectInstaller>
{
    private ProjectEvents _projectEvents;
    public override void InstallBindings()
    {
        ProjectEvents projectEvents = new();
        Container.BindInstance(projectEvents).AsSingle();

    }
    public override void Start()
    {
        _projectEvents.ProjectStarted?.Invoke();
    }

    private static void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void RegisterEvents()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene loadedScene, LoadSceneMode arg1)
    {
        if (loadedScene.name== "Login")
        {
            LoadScene("Main");
        }
    }
}
