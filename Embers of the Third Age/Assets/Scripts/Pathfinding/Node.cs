using UnityEngine;

public class Node 
{
    public readonly bool walkable;
    public readonly Vector2 worldPosition;

    public Node(bool walkable, Vector2 worldPosition)
    {
        this.walkable = walkable;
        this.worldPosition = worldPosition;
    }
}
