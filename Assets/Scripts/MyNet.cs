using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNet : NetworkDiscovery
{
    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        NetworkManager.singleton.networkAddress = fromAddress;
        NetworkManager.singleton.StartClient();
        Debug.Log("Received broadcast from: " + fromAddress + " with the data: " + data);
    }
    
    
    public void StartServer()
    {
        NetworkManager.singleton.networkAddress = IPManager.GetIP(ADDRESSFAM.IPv4);
        Initialize();
        bool state = StartAsServer();

        Debug.Log("Server state:" +state+ "\nAt port: " + broadcastPort + " and Address: " + NetworkManager.singleton.networkAddress);
    }


    public void StartClient()
    {

        Initialize();
        bool state = StartAsClient();
        Debug.Log("Client state:" + state + "\nAt port: " + broadcastPort + " and Address: " + NetworkManager.singleton.networkAddress);
    }

    public void StopCast()
    {
        StopBroadcast();
        Debug.Log("Stop broadcast");
    }

    
}
