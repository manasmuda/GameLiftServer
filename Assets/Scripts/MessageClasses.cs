﻿using System;
using System.Collections.Generic;

[Serializable]
public enum MessageType
{
    Connect,
    Disconnect,
    Ready,
    Reject,
    PlayerAccepted,
    PlayerLeft,
    GameStarted,
    GameReady,
    ServerTick
};

// We will use the same message for all requests so it will include a type and optional float values (used for position and orientation)
[Serializable]
public class SimpleMessage
{
    public SimpleMessage(MessageType type, string message = "")
    {
        this.messageType = type;
        this.message = message;
        this.listData = new List<object> { };
        this.dictData = new Dictionary<string, object> { };
        this.listdictdata = new List<Dictionary<string, object>> { };
        this.time = DateTime.UtcNow.Millisecond;
    }

    public MessageType messageType { get; set; }
    public string message { get; set; }
    public int clientId { get; set; }
    public int time { get; set; }
    public string playerId { get; set; }
    public string team { get; set; }
    public List<object> listData { get; set; }
    public Dictionary<string, object> dictData { get; set; }
    public List<Dictionary<string, object>> listdictdata { get; set; }
    public int intData { get; set; }
    public string stringData { get; set; }
    public float floatData { get; set; }
    public int[] intArrData { get; set; }
    public float[] floatArrData { get; set; }
    public string[] stringArrData { get; set; }
  
}