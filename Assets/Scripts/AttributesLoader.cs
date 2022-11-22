using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.TextCore.Text;
using TMPro;

public class AttributesLoader : MonoBehaviour
{
    [SerializeField]
    private Transform parent;

    [SerializeField]
    private GameObject avatar;

    [SerializeField]
    private int numberOfFaceTypes;

    private GameObject[][] beards;
    private GameObject[][] eyes;
    private GameObject[][] eyebrows;
    private GameObject[] faces;
    private GameObject[][] haircuts;
    private GameObject[][] mouthes;
    private GameObject[][] noses;
    private GameObject[] shirts;
    private GameObject[][] accessories;

    private AvatarSettings avatarSettings;

    private void Awake()
    {
        avatarSettings = avatar.GetComponent<AvatarSettings>();

        beards = new GameObject[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            beards[i] = LoadPerefabs("Beard", i);

        eyes = new GameObject[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            eyes[i] = LoadPerefabs("Eye", i);

        eyebrows = new GameObject[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            eyebrows[i] = LoadPerefabs("Eyebrow", i);

        faces = LoadPerefabs("Face");

        haircuts = new GameObject[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            haircuts[i] = LoadPerefabs("Haircut", i);

        mouthes = new GameObject[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            mouthes[i] = LoadPerefabs("Mouth", i);

        noses = new GameObject[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            noses[i] = LoadPerefabs("Nose", i);

        shirts = LoadPerefabs("Shirt");

        accessories = new GameObject[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            accessories[i] = LoadPerefabs("Accessory", i);

        DisableAllAttributes();

        LoadAttribute(0);
    }

    public void LoadAttribute(int index)
    {
        DisableAllAttributes();

        switch (index)
        {
            case 0:
                for (int i = 0; i < faces.Length; i++)
                    if (faces[i] != null)
                        faces[i].SetActive(true);
                break;
            case 1:
                for (int i = 0; i < haircuts[avatarSettings.FaceType].Length; i++)
                    if (haircuts[avatarSettings.FaceType][i] != null)
                        haircuts[avatarSettings.FaceType][i].SetActive(true);
                break;
            case 2:
                for (int i = 0; i < eyebrows[avatarSettings.FaceType].Length; i++)
                    if (eyebrows[avatarSettings.FaceType][i] != null)
                        eyebrows[avatarSettings.FaceType][i].SetActive(true);
                break;
            case 3:
                for (int i = 0; i < eyes[avatarSettings.FaceType].Length; i++)
                    if (eyes[avatarSettings.FaceType][i] != null)
                        eyes[avatarSettings.FaceType][i].SetActive(true);
                break;
            case 4:
                for (int i = 0; i < noses[avatarSettings.FaceType].Length; i++)
                    if (noses[avatarSettings.FaceType][i] != null)
                        noses[avatarSettings.FaceType][i].SetActive(true);
                break;
            case 5:
                for (int i = 0; i < mouthes[avatarSettings.FaceType].Length; i++)
                    if (mouthes[avatarSettings.FaceType][i] != null)
                        mouthes[avatarSettings.FaceType][i].SetActive(true);
                break;
            case 6:
                for (int i = 0; i < beards[avatarSettings.FaceType].Length; i++)
                    if (beards[avatarSettings.FaceType][i] != null)
                        beards[avatarSettings.FaceType][i].SetActive(true);
                break;
            case 7:
                for (int i = 0; i < shirts.Length; i++)
                    if (shirts[i] != null)
                        shirts[i].SetActive(true);
                break;
            case 8:
                for (int i = 0; i < accessories[avatarSettings.FaceType].Length; i++)
                    if (accessories[avatarSettings.FaceType][i] != null)
                        accessories[avatarSettings.FaceType][i].SetActive(true);
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
            {
                prefabs[i] = Instantiate(Resources.Load<GameObject>(prefabsFolderPath + filenames[i]), parent);
                prefabs[i].GetComponent<ShopButtonHandler>().avatarSettings = avatarSettings;
                prefabs[i].GetComponent<ShopButtonHandler>().number = i;
            }
        }

        return prefabs;
    }

    private void DisableAllAttributes()
    {
        for (int i = 0; i < haircuts.Length; i++)
            for (int j = 0; j < haircuts[i].Length; j++)
                if(haircuts[i][j] != null)
                    haircuts[i][j].SetActive(false);

        for (int i = 0; i < eyebrows.Length; i++)
            for (int j = 0; j < eyebrows[i].Length; j++)
                if (eyebrows[i][j] != null)
                    eyebrows[i][j].SetActive(false);

        for (int i = 0; i < eyes.Length; i++)
            for (int j = 0; j < eyes[i].Length; j++)
                if (eyes[i][j] != null)
                    eyes[i][j].SetActive(false);

        for(int i = 0; i < noses.Length; i++)
            for (int j = 0; j < noses[i].Length; j++)
                if (noses[i][j] != null)
                    noses[i][j].SetActive(false);

        for (int i = 0; i < mouthes.Length; i++)
            for (int j = 0; j < mouthes[i].Length; j++)
                if (mouthes[i][j] != null)
                    mouthes[i][j].SetActive(false);

        for (int i = 0; i < beards.Length; i++)
            for (int j = 0; j < beards[i].Length; j++)
                if (beards[i][j] != null)
                    beards[i][j].SetActive(false);

        for (int i = 0; i < accessories.Length; i++)
            for (int j = 0; j < accessories[i].Length; j++)
                if (accessories[i][j] != null)
                    accessories[i][j].SetActive(false);

        for (int i = 0; i < faces.Length; i++)
            if (faces[i] != null)
                faces[i].SetActive(false);

        for (int i = 0; i < shirts.Length; i++)
            if (shirts[i] != null)
                shirts[i].SetActive(false);
    }
}
