using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class NetworkManager : MonoBehaviour
{
    public void CreateLobby()
    {
        NetworkLobbyManager.singleton.maxConnections = 6;
        NetworkLobbyManager.singleton.StartHost();
        Debug.Log(NetworkLobbyManager.singleton.networkPort);
        Debug.Log(NetworkLobbyManager.singleton.networkAddress);
    }


}
