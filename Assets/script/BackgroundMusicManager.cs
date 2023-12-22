using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public static BackgroundMusicManager instance;
    public AudioSource audioSource;
    private string volumeKey = "BGMVolume"; // 用于保存音量设置的键值

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 保持在不同场景中
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
        LoadVolume(); // 加载音量设置
    }

    void LoadVolume()
    {
        if (PlayerPrefs.HasKey(volumeKey))
        {
            float savedVolume = PlayerPrefs.GetFloat(volumeKey);
            audioSource.volume = savedVolume;
        }
        else
        {
            audioSource.volume = 0.5f; // 默认音量
        }
    }

    public void SaveVolume()
    {
        PlayerPrefs.SetFloat(volumeKey, audioSource.volume);
        PlayerPrefs.Save();
    }

    public void PlayMusic(AudioClip music)
    {
        audioSource.clip = music;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void SetVolume(float newVolume)
    {
        audioSource.volume = newVolume;
        SaveVolume(); // 保存音量设置
    }
}