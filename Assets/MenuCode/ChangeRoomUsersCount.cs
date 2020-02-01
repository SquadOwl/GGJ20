using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.PackageManager;

public class ChangeRoomUsersCount : MonoBehaviour
{
    Button[] buttons;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        var script = canvas.GetComponent<ScriptableObject>();
        buttons = this.GetComponentsInChildren<Button>();
        var wholeImgArr = new List<object>();

        for (int i = 0; i < buttons.Length; i++)
        {
            var button = buttons[i];
            var images = button.GetComponentsInChildren<RawImage>();
            wholeImgArr.Add(new List<object> { button, images });

            foreach (var item in images)
            {
                var curTag = item.tag;

                if (curTag[0] == 'u' && i == 0)
                    item.gameObject.SetActive(false);

                else if(curTag[0] == 'e' && i != 0)
                    item.gameObject.SetActive(false);

                if(i == 0)
                    item.color = new Vector4(1f, 0.32f, 0.32f, 1);

                else
                    item.color = new Vector4(0.91f, 0.6f, 0.6f, 1);
            }

            button.onClick.AddListener(delegate
            {

                var curTag = button.tag;
                var curNumber = curTag.Substring(curTag.Length - 4, 1);
                int usersCount = 1;

                if (int.TryParse(curNumber, out usersCount))
                    usersCount = int.Parse(curNumber);

                //set users count code
               
                for (int j = 0; j < buttons.Length; j++)
                {
                    var curImage = buttons[j].GetComponentsInChildren<RawImage>()[0];

                    if (j < usersCount)
                        curImage.color = new Vector4(0.96f, 0.21f, 0.21f, 1);

                    else
                        curImage.color = new Vector4(0.91f, 0.6f, 0.6f, 1);
                }
            });
        }
    }
}
