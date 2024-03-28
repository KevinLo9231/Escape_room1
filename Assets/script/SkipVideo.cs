using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SkipVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer; // 指向你的 Video Player

    public void skip()
    {
        videoPlayer.Stop(); // 停止影片播放
        SceneManager.LoadScene("FirstScene"); // 加載到firstscene
    }
}
