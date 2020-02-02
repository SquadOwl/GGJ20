
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Networking;

public class LanGameButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Text buttonText;

    public string m_networkAddress;
    public string networkAddress
    {
        get { return m_networkAddress; }
        set
        {
            m_networkAddress = value;
            buttonText.text = value;
        }
    }

    #region IPointerClickHandler implementation
    public void OnPointerClick(PointerEventData eventData)
    {
        MyLanNetManager.singleton.networkAddress = networkAddress;
        MyLanNetManager.singleton.GetComponent<MyLanNetManager>().StartGameClient();
    }
    #endregion
}