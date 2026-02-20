using Barotrauma.Networking;

namespace Barotrauma.LuaCs.Compatibility;

public interface ILuaCsNetworking : ILuaCsShim
{
    void Receive(string netId, LuaCsAction action);
#if SERVER
    void Send(IWriteMessage mesage, NetworkConnection connection = null, DeliveryMethod deliveryMethod = DeliveryMethod.Reliable);
#elif CLIENT
    void Send(IWriteMessage mesage, DeliveryMethod deliveryMethod = DeliveryMethod.Reliable);
#endif
}
