using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonHandler : MonoBehaviour
{
    public AvatarSettings avatarSettings;
    public int number;

    public void SetType(int index)
    {
        if (!avatarSettings)
            return;

        switch (index)
        {
            case 0:
                avatarSettings.FaceType = number;
                break;
            case 1:
                avatarSettings.HaircutType = number;
                break;
            case 2:
                avatarSettings.BrowType = number;
                break;
            case 3:
                avatarSettings.EyeType = number;
                break;
            case 4:
                avatarSettings.NoseType = number;
                break;
            case 5:
                avatarSettings.MouthType = number;
                break;
            case 6:
                avatarSettings.BeardType = number;
                break;
            case 7:
                avatarSettings.ShirtType = number;
                break;
            case 8:
                avatarSettings.AccessoryType = number;
                break;
            default:
                break;
        }

    }
}
