using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class LobbyManager : MonoBehaviour
{
    public void CreateLobby()
    {
        NetworkLobbyManager.singleton.networkAddress = "192.168.0.0";
        NetworkLobbyManager.singleton.maxConnections = 6;
        NetworkLobbyManager.singleton.StartHost();
        Debug.Log(NetworkLobbyManager.singleton.networkPort);
        Debug.Log(NetworkLobbyManager.singleton.networkAddress);
    }

    public void GetIP()
    {
        Debug.Log(NetworkManager.singleton.networkAddress);
    }
}
