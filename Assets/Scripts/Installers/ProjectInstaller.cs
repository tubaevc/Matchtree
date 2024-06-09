using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Events;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class ProjectInstaller : MonoInstaller<ProjectInstaller>
{
    private ProjectEvents _projectEvents;
    private InputEvents _inputEvents;
    private GridEvents _gridEvents;
    public override void InstallBindings()
    {
        ProjectEvents projectEvents = new();
        Container.BindInstance(projectEvents).AsSingle();
        _inputEvents = new InputEvents();
        Container.BindInstance(_inputEvents).AsSingle();
        _gridEvents = new GridEvents();
        Container.BindInstance(_gridEvents).AsSingle();

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
        if (loadedScene.name== EnvVar.LoginSceneName)
        {
            LoadScene(EnvVar.MainSceneName);
        }
    }
}
