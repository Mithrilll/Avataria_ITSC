using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.TextCore.Text;
using TMPro;

public class AttributesLoader : MonoBehaviour
{
    [SerializeField]
    private GameObject avatar;

    [SerializeField]
    private string haircutsFolderName;
    private GameObject[] haircuts;

    [SerializeField]
    private string eyesFolderName;
    private GameObject[] eyes;

    private AvatarSettings avatarSettings;

    private void Awake()
    {
        avatarSettings = avatar.GetComponent<AvatarSettings>();

        haircuts = LoadPerefabs(haircutsFolderName, avatarSettings.FaceType);
        eyes = LoadPerefabs(eyesFolderName);

        DisableAllAttributes();
    }

    public void LoadAttribute(int index)
    {
        DisableAllAttributes();

        switch (index)
        {
            case 0:

                break;
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            default:
                break;
        }
    }

    private GameObject[] LoadPerefabs(string prefabFoldername, int faceType = 0)
    {
        string prefabsFolderPath = "Prefabs/" + prefabFoldername + "/";
        int numberOfPrefabs = 1000;

        string[] filenames = new string[numberOfPrefabs];
        GameObject[] prefabs = new GameObject[numberOfPrefabs];
        for (int i = 0; i < numberOfPrefabs; i++)
            filenames[i] = faceType + "_" + i;

        for (int i = 0; i < numberOfPrefabs; i++)
        {
            if (Resources.Load<GameObject>(prefabsFolderPath + filenames[i]))
                prefabs[i] = Instantiate(Resources.Load<GameObject>(prefabsFolderPath + filenames[i]), gameObject.transform);
        }

        return prefabs;
    }

    private void DisableAllAttributes()
    {

    }
}
