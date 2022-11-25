using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
public class SetAvatars : MonoBehaviour
{

    [SerializeField]
    private GameObject scrollbar_content;
    [SerializeField]
    private GameObject plyinfo_pref;
    string[] path_fo_obj = {
        "vk/Text",
        "job/Text",
        "les/Text",
        "main_text/Text",
    };
    string[] ban_names ={
        "Dima_Glazunov.txt",
        "Aleksei_Pilipenko.txt",
        "Gleb_Makhrin.txt",
        "Alexandr_Rybalov.txt"
    };
    void Start(){
        string [] count_avatars = Directory.GetFiles(Application.streamingAssetsPath, "*.txt");
        int i = 0;
        foreach(var item in count_avatars)
        {
            GameObject plyinfo = Instantiate(plyinfo_pref) as GameObject;
            plyinfo.transform.SetParent(scrollbar_content.transform, false);
            plyinfo.transform.localScale = new Vector3(1, 1, 1);
            plyinfo.name = "plyinfo_" + i.ToString();
            foreach(var finame in ban_names){
                if(finame == Path.GetFileName(item)){
                    plyinfo.transform.Find("remove_but").gameObject.SetActive(false);
                }
            }
            plyinfo.transform.Find("remove_but/path_obj").GetComponent<TextMeshProUGUI>().text = item;
            string fileContent = System.IO.File.ReadAllText(item);
            string[] st = fileContent.Split('\n');
            int i_pt = 0;
            foreach(var pt in path_fo_obj){
                TextMeshProUGUI name_text = plyinfo.transform.Find(pt).GetComponent<TextMeshProUGUI>();
                name_text.text = st[i_pt];
                i_pt++;
            }
            AvatarSettings avatarSettings = plyinfo.transform.Find("Avatar").GetComponent<AvatarSettings>();
            avatarSettings.FaceType = int.Parse(st[4]);
            avatarSettings.EyeType = int.Parse(st[5]);
            avatarSettings.BrowType = int.Parse(st[6]);
            avatarSettings.MouthType = int.Parse(st[7]);
            avatarSettings.BeardType = int.Parse(st[8]);
            avatarSettings.NoseType = int.Parse(st[9]);
            avatarSettings.HaircutType = int.Parse(st[10]);
            avatarSettings.ShirtType = int.Parse(st[11]);
            avatarSettings.AccessoryType = int.Parse(st[12]);
            i++;
        }
    }
}
