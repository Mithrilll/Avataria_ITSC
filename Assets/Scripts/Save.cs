using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using TMPro;
using UnityEngine;

public class Save : MonoBehaviour
{
    [SerializeField]
    private AvatarSettings avatarSettings;

    [SerializeField]
    private TextMeshProUGUI avatarName;
    [SerializeField]
    private TextMeshProUGUI avatarRole;
    [SerializeField]
    private TextMeshProUGUI avatarCourse;
    [SerializeField]
    private TextMeshProUGUI avatarAbout;

    public void SaveAvatar()
    {
        string path = Path.Combine(Application.streamingAssetsPath, DateTime.Now.ToString("dd.MM.yyyy.hh.mm.ss") + ".txt");
        Debug.Log(path);
        FileInfo fi1 = new FileInfo(path);

        if (!fi1.Exists)
        {
            //Create a file to write to.
            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine(avatarName.text);
                sw.WriteLine(avatarRole.text);
                sw.WriteLine(avatarCourse.text);
                sw.WriteLine(avatarAbout.text);
                sw.WriteLine(avatarSettings.FaceType);
                sw.WriteLine(avatarSettings.EyeType);
                sw.WriteLine(avatarSettings.BrowType);
                sw.WriteLine(avatarSettings.MouthType);
                sw.WriteLine(avatarSettings.BeardType);
                sw.WriteLine(avatarSettings.NoseType);
                sw.WriteLine(avatarSettings.HaircutType);
                sw.WriteLine(avatarSettings.ShirtType);
                sw.WriteLine(avatarSettings.AccessoryType);
            }
        }

        return;
    }
}
