using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyLanNetManager : NetworkManager
{
    [SerializeField] GameObject UI;
    public NetworkDiscovery discovery;
    [HideInInspector] public bool isHost;

    void Start()
    {

    }

    public void StartGameHost()
    {
        UI.SetActive(false);
        isHost = true;
        StartHost();
    }

    public void StartGameClient()
    {
        UI.SetActive(false);
        isHost = false;
        StartClient();
    }

    public override void OnStartHost()
    {
        discovery.StopBroadcast();
        Debug.Log("Start Host Broadcast....");
        discovery.broadcastData = networkPort.ToString();
        discovery.StartAsServer();

    }

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        base.OnServerAddPlayer(conn, playerControllerId);
        if (conn.connectionId > 0)
        {
            Debug.Log("Stop Host Broadcast...");
            discovery.StopBroadcast();
        }
    }

    public override void OnStartClient(NetworkClient client)
    {
        base.OnStartClient(client);
    }

    public override void OnStopClient()
    {
        UI.SetActive(true);
        discovery.StopBroadcast();
        Destroy(gameObject);
    }
}
