using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RemoveFile : MonoBehaviour
{
    [SerializeField] private Button remove_ply_but;
    [SerializeField] private TextMeshProUGUI Path;
    void Start()
    {
        if (remove_ply_but) remove_ply_but.onClick.AddListener(() => RemovePly());
    }
    void RemovePly(){
        File.Delete(Path.text);
        File.Delete(Path.text + ".meta");
    }
}
