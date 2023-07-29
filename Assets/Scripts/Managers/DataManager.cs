using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    // Persistent data keys
    public static string masterVolume = "masterVolume";
    public static string musicVolume = "musicVolume";
    public static string sfxVolume = "sfxVolume";

    // Default values
    public static float masterVolumeDefault = 1f;
    public static float musicVolumeDefault = 1f;
    public static float sfxVolumeDefault = 1f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            SetConfig();
            LoadData();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private static void SetConfig()
    {
        // build your config
        var config = new FBPPConfig()
        {
            SaveFileName = "URP-template-name.txt",
            AutoSaveData = false,
            ScrambleSaveData = false,
            // EncryptionSecret = "spadersecretcode",
            // SaveFilePath = "C:/Repositories/unity-2d-builtin-template"
        };
        // pass it to FBPP
        FBPP.Start(config);
    }

    private static void LoadData()
    {
        // print(GlobalData.numAchievements);
    }
}
