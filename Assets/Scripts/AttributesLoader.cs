using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class AttributesLoader : MonoBehaviour
{
    [SerializeField]
    private GameObject avatar;

    [SerializeField]
    private GameObject[] faces;

    [SerializeField]
    private GameObject[] haircuts0;
    [SerializeField]
    private GameObject[] haircuts1;
    //[SerializeField]
    //private GameObject[] haircuts2;
    //[SerializeField]
    //private GameObject[] haircuts3;

    [SerializeField]
    private GameObject[] brows0;
    [SerializeField]
    private GameObject[] brows1;
    //[SerializeField]
    //private GameObject[] brows2;
    //[SerializeField]
    //private GameObject[] brows3;

    [SerializeField]
    private GameObject[] eyes0;
    [SerializeField]
    private GameObject[] eyes1;
    //[SerializeField]
    //private GameObject[] eyes2;
    //[SerializeField]
    //private GameObject[] eyes3;

    [SerializeField]
    private GameObject[] noses0;
    [SerializeField]
    private GameObject[] noses1;
    //[SerializeField]
    //private GameObject[] noses2;
    //[SerializeField]
    //private GameObject[] noses3;

    [SerializeField]
    private GameObject[] mouses0;
    [SerializeField]
    private GameObject[] mouses1;
    //[SerializeField]
    //private GameObject[] mouses2;
    //[SerializeField]
    //private GameObject[] mouses3;

    [SerializeField]
    private GameObject[] beards0;
    [SerializeField]
    private GameObject[] beards1;
    //[SerializeField]
    //private GameObject[] beards2;
    //[SerializeField]
    //private GameObject[] beards3;

    [SerializeField]
    private GameObject[] accessories0;
    [SerializeField]
    private GameObject[] accessories1;
    //[SerializeField]
    //private GameObject[] accessories2;
    //[SerializeField]
    //private GameObject[] accessories3;

    [SerializeField]
    private GameObject[] shirts;

    private GameObject[][] haircuts = new GameObject[2][];
    private GameObject[][] brows = new GameObject[2][];
    private GameObject[][] eyes = new GameObject[2][];
    private GameObject[][] noses = new GameObject[2][];
    private GameObject[][] mouses = new GameObject[2][];
    private GameObject[][] beards = new GameObject[2][];
    private GameObject[][] accessories = new GameObject[2][];

    private AvatarSettings avatarSettings;

    private void Awake()
    {
        avatarSettings = avatar.GetComponent<AvatarSettings>();

        haircuts[0] = haircuts0;
        haircuts[1] = haircuts1;
        //haircuts[2] = haircuts2;
        //haircuts[3] = haircuts3;

        brows[0] = brows0;
        brows[1] = brows1;
        //brows[2] = brows2;
        //brows[3] = brows3;

        eyes[0] = eyes0;
        eyes[1] = eyes1;
        //eyes[2] = eyes2;
        //eyes[3] = eyes3;

        noses[0] = noses0;
        noses[1] = noses1;
        //noses[2] = noses2;
        //noses[3] = noses3;

        mouses[0] = mouses0;
        mouses[1] = mouses1;
        //mouses[2] = mouses2;
        //mouses[3] = mouses3;

        beards[0] = beards0;
        beards[1] = beards1;
        //beards[2] = beards2;
        //beards[3] = beards3;

        accessories[0] = accessories0;
        accessories[1] = accessories1;
        //accessories[2] = accessories2;
        //accessories[3] = accessories3;

        DisableAllAttributes();

        foreach (GameObject i in faces)
            i.SetActive(true);
    }

    public void LoadAttribute(int index)
    {
        DisableAllAttributes();

        switch (index)
        {
            case 0:
                foreach (GameObject i in faces)
                    i.SetActive(true);
                break;
            case 1:
                foreach (GameObject i in haircuts[avatarSettings.FaceType])
                    i.SetActive(true);
                break;
            case 2:
                foreach (GameObject i in brows[avatarSettings.FaceType])
                    i.SetActive(true);
                break;
            case 3:
                foreach (GameObject i in eyes[avatarSettings.FaceType])
                    i.SetActive(true);
                break;
            case 4:
                foreach (GameObject i in noses[avatarSettings.FaceType])
                    i.SetActive(true);
                break;
            case 5:
                foreach (GameObject i in mouses[avatarSettings.FaceType])
                    i.SetActive(true);
                break;
            case 6:
                foreach (GameObject i in beards[avatarSettings.FaceType])
                    i.SetActive(true);
                break;
            case 7:
                foreach (GameObject i in shirts)
                    i.SetActive(true);
                break;
            case 8:
                foreach (GameObject i in accessories[avatarSettings.FaceType])
                    i.SetActive(true);
                break;
            default:
                break;
        }
    }

    private void DisableAllAttributes()
    {
        foreach (GameObject i in faces)
            i.SetActive(false);

        for (int i = 0; i < 2; i++)
            foreach (GameObject j in haircuts[i])
                j.SetActive(false);

        for (int i = 0; i < 2; i++)
            foreach (GameObject j in brows[i])
                j.SetActive(false);

        for (int i = 0; i < 2; i++)
            foreach (GameObject j in eyes[i])
                j.SetActive(false);

        for (int i = 0; i < 2; i++)
            foreach (GameObject j in noses[i])
                j.SetActive(false);

        for (int i = 0; i < 2; i++)
            foreach (GameObject j in mouses[i])
                j.SetActive(false);

        for (int i = 0; i < 2; i++)
            foreach (GameObject j in beards[i])
                j.SetActive(false);

        foreach (GameObject i in shirts)
            i.SetActive(false);
        ;
        for (int i = 0; i < 2; i++)
            foreach (GameObject j in accessories[i])
                j.SetActive(false);
    }
}
