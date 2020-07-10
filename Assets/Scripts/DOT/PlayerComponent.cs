﻿using Unity.Entities;

[GenerateAuthoringComponent]
public struct PlayerComponent : IComponentData
{
    public float speed;
    public float rotationAngle;
    //public Entity _prefab;
}
