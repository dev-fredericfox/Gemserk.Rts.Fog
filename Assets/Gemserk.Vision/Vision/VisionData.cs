using System;
using UnityEngine;

namespace Gemserk.Vision
{
    [Serializable]
    public struct VisionData
    {
        public int player;
        public Vector2 position;
        public Vector3 position3s;
        public float range;
        public short groundLevel;
    }
}