﻿using System;
using TrueCraft.API;
using TrueCraft.API.Server;
using TrueCraft.Core.Networking.Packets;
using TrueCraft.API.Networking;
using TrueCraft.API.Logging;

namespace TrueCraft.Handlers
{
    public static class PacketHandlers
    {
        public static void RegisterHandlers(IMultiplayerServer server)
        {
            server.RegisterPacketHandler(new KeepAlivePacket().ID, HandleKeepAlive);
            server.RegisterPacketHandler(new ChatMessagePacket().ID, HandleChatMessage);
            server.RegisterPacketHandler(new DisconnectPacket().ID, HandleDisconnect);

            server.RegisterPacketHandler(new HandshakePacket().ID, LoginHandlers.HandleHandshakePacket);
            server.RegisterPacketHandler(new LoginRequestPacket().ID, LoginHandlers.HandleLoginRequestPacket);

            server.RegisterPacketHandler(new PlayerPositionPacket().ID, EntityHandlers.HandlePlayerPositionPacket);

            server.RegisterPacketHandler(new PlayerDiggingPacket().ID, InteractionHandlers.HandlePlayerDiggingPacket);
            server.RegisterPacketHandler(new PlayerBlockPlacementPacket().ID, InteractionHandlers.HandlePlayerBlockPlacementPacket);
            server.RegisterPacketHandler(new ChangeHeldItemPacket().ID, InteractionHandlers.HandleChangeHeldItem);
        }

        internal static void HandleKeepAlive(IPacket _packet, IRemoteClient _client, IMultiplayerServer server)
        {
            // TODO
        }

        internal static void HandleChatMessage(IPacket _packet, IRemoteClient _client, IMultiplayerServer _server)
        {
            // TODO: Abstract this to support things like commands
            // TODO: Sanitize messages
            var packet = (ChatMessagePacket)_packet;
            var server = (MultiplayerServer)_server;
            var args = new ChatMessageEventArgs(_client, packet.Message);
            server.OnChatMessageReceived(args);
            if (!args.PreventDefault)
                server.SendMessage("<{0}> {1}", _client.Username, packet.Message);
        }

        internal static void HandleDisconnect(IPacket _packet, IRemoteClient _client, IMultiplayerServer server)
        {
            throw new Exception("Player disconnected"); // TODO: PlayerDisconnectException or something
        }
    }
}