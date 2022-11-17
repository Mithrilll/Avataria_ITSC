using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSettings : MonoBehaviour
{
    private int faceType;
    public int FaceType
    {
        get { return faceType; }
        set { faceType = value; }
    }

    public void Awake()
    {
        faceType = 0;
    }
}
