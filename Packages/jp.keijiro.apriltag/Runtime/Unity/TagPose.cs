using UnityEngine;

namespace AprilTag {

//
// Tag pose structure for storing an estimated pose
//
public struct TagPose
{
    public int ID { get; }
    public Vector3 Position { get; }
    public Quaternion Rotation { get; }

    public Vector2 ImagePosition { get; }

    public TagPose(
        int id,
        Vector3 position,
        Quaternion rotation,
        Vector2 imagePosition)
    {
        ID = id;
        Position = position;
        Rotation = rotation;
        ImagePosition = imagePosition;
    }
}

} // namespace AprilTag
