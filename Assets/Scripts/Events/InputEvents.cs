using Components;
using UnityEngine.Events;
using  UnityEngine;

namespace Events
{
    public class InputEvents
    {
        public UnityAction<Tile, Vector3> MouseDownGrid;
        public UnityAction<Vector3> MouseUpGrid;
    }
}