using Components;
using UnityEngine;

namespace DefaultNamespace.Settings
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "MENUNAME", order = 0)]
    public class ProjectSettings : ScriptableObject
    {
        [SerializeField] private GridManager.Settings _gridManagerSettings;
        public GridManager.Settings GridManagerSettings => _gridManagerSettings;
    }
}