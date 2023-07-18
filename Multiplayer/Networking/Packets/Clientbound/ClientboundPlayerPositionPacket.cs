using UnityEngine;

namespace Multiplayer.Networking.Packets.Clientbound;

public class ClientboundPlayerPositionPacket
{
    public byte Id { get; set; }
    public Vector3 Position { get; set; }
    public float RotationY { get; set; }
}