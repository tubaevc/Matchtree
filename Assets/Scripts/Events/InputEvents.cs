using System.Numerics;
using Components;
using UnityEngine.Events;
using Vector3 = UnityEngine.Vector3;

namespace Events
{
    public class InputEvents
    {
        public UnityAction<Tile, Vector3> MouseDownGrid;
        public UnityAction<Vector3> MouseUpGrid;
    }
}