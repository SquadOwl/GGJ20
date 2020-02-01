using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNet : NetworkDiscovery
{
    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        Debug.Log("Received broadcast from: " + fromAddress + " with the data: " + data);
    }
    

    public void Init()
    {
        Initialize();
    }

    public void StartServer()
    {
        StartAsServer();
        Debug.Log("StartAsServer at port: " + this.broadcastPort + " and Address: " + IPManager.GetIP(ADDRESSFAM.IPv4));
    }

    public void StartClient()
    {
        
        StartAsClient();
        Debug.Log("StartAsClient at port: " + this.broadcastPort + " and Address: " + IPManager.GetIP(ADDRESSFAM.IPv4));
    }

    public void StopCast()
    {
        StopBroadcast();
        Debug.Log("Stop broadcast");
    }

    public void Update()
    {
        if(broadcastsReceived != null)
        {

            foreach (var item in broadcastsReceived)
            {
                Debug.Log("Key: " + item.Key + " Address: " + item.Value.serverAddress);
            }
        }
    }
}
