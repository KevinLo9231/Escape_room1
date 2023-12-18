using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public AudioSource bgmAudio; // 音樂模塊
    public Slider volumeslider; // 音量滑輪

    private static GameManager music; 

    private void Awake()
    {
        if (music == null)
        {
            music = this;

            DontDestroyOnLoad(gameObject); // 聲音可以留到下一個場景，不被摧毀
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update() //循環播放BGM
    {
        if (bgmAudio != null)
        {
            bgmAudio.volume = volumeslider.value;
        }
    }
}

