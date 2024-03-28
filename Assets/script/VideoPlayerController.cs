using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd; //影片播放完畢時，會調用OnVideoEnd
    }

    private void OnVideoEnd(VideoPlayer videoPlayer)
    {
        SceneManager.LoadScene("FirstScene"); // 播放完畢時，加載到firstscene
    }
}
