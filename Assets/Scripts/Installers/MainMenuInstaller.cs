using System.Collections;
using System.Collections.Generic;
using Components.UI;
using Events;
using UnityEngine;
using Zenject;

public class MainMenuInstaller : MonoInstaller<MainMenuInstaller>
{
    public override void InstallBindings()
    {
        Container.BindInstance(MainMenuEvents.Instance).AsSingle();
        Container.Bind<MainMenuManager>().FromComponentInHierarchy().AsSingle();
    }
}
