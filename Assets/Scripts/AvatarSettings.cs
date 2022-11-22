using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSettings : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer face;
    [SerializeField]
    private SpriteRenderer eyes;
    [SerializeField]
    private SpriteRenderer brows;
    [SerializeField]
    private SpriteRenderer mouth;
    [SerializeField]
    private SpriteRenderer beard;
    [SerializeField]
    private SpriteRenderer nose;
    [SerializeField]
    private SpriteRenderer haircut;
    [SerializeField]
    private SpriteRenderer shirt;
    [SerializeField]
    private SpriteRenderer accessory;

    [SerializeField]
    private int numberOfFaceTypes;

    private Sprite[][] beardsSprite;
    private Sprite[][] eyesSprite;
    private Sprite[][] eyebrowsSprite;
    private Sprite[] facesSprite;
    private Sprite[][] haircutsSprite;
    private Sprite[][] mouthesSprite;
    private Sprite[][] nosesSprite;
    private Sprite[] shirtsSprite;
    private Sprite[][] accessoriesSprite;

    private int faceType = 0;
    public int FaceType
    {
        get { return faceType; }
        set { faceType = value; }
    }

    private int eyeType = 0;
    public int EyeType
    {
        get { return eyeType; }
        set { eyeType = value; }
    }

    private int browType = 0;
    public int BrowType
    {
        get { return browType; }
        set { browType = value; }
    }

    private int mouthType = 0;
    public int MouthType
    {
        get { return mouthType; }
        set { mouthType = value; }
    }

    private int beardType = 0;
    public int BeardType
    {
        get { return beardType; }
        set { beardType = value; }
    }

    private int noseType = 0;
    public int NoseType
    {
        get { return noseType; }
        set { noseType = value; }
    }

    private int haircutType = 0;
    public int HaircutType
    {
        get { return haircutType; }
        set { haircutType = value; }
    }

    private int shirtType = 0;
    public int ShirtType
    {
        get { return shirtType; }
        set { shirtType = value; }
    }

    private int accessoryType = 0;
    public int AccessoryType
    {
        get { return accessoryType; }
        set { accessoryType = value; }
    }

    public void Awake()
    {
        beardsSprite = new Sprite[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            beardsSprite[i] = LoadSprites("Beard", i);

        eyesSprite = new Sprite[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            eyesSprite[i] = LoadSprites("Eye", i);

        eyebrowsSprite = new Sprite[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            eyebrowsSprite[i] = LoadSprites("Eyebrow", i);

        facesSprite = LoadSprites("Face");

        haircutsSprite = new Sprite[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            haircutsSprite[i] = LoadSprites("Haircut", i);

        mouthesSprite = new Sprite[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            mouthesSprite[i] = LoadSprites("Mouth", i);

        nosesSprite = new Sprite[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            nosesSprite[i] = LoadSprites("Nose", i);

        shirtsSprite = LoadSprites("Shirt");

        accessoriesSprite = new Sprite[numberOfFaceTypes][];
        for (int i = 0; i < numberOfFaceTypes; i++)
            accessoriesSprite[i] = LoadSprites("Accessory", i);
    }

    private void Update()
    {
        face.sprite = facesSprite[faceType];
        eyes.sprite = eyesSprite[faceType][eyeType];
        brows.sprite = eyebrowsSprite[faceType][browType];
        mouth.sprite = mouthesSprite[faceType][mouthType];
        beard.sprite = beardsSprite[faceType][beardType];
        nose.sprite = nosesSprite[faceType][noseType];
        haircut.sprite = haircutsSprite[faceType][haircutType];
        shirt.sprite = shirtsSprite[shirtType];
        accessory.sprite = accessoriesSprite[faceType][accessoryType];
    }

    private Sprite[] LoadSprites(string prefabFoldername, int faceType = 0)
    {
        string prefabsFolderPath = "Sprites/" + prefabFoldername + "/";
        int numberOfPrefabs = 1000;

        string[] filenames = new string[numberOfPrefabs];
        Sprite[] prefabs = new Sprite[numberOfPrefabs];
        for (int i = 0; i < numberOfPrefabs; i++)
            filenames[i] = faceType + "_" + i;

        for (int i = 0; i < numberOfPrefabs; i++)
        {
            if (Resources.Load<Texture2D>(prefabsFolderPath + filenames[i]))
                prefabs[i] = Resources.Load<Sprite>(prefabsFolderPath + filenames[i]);
        }

        return prefabs;
    }
}
