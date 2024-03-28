using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd; //�v�����񧹲��ɡA�|�ե�OnVideoEnd
    }

    private void OnVideoEnd(VideoPlayer videoPlayer)
    {
        SceneManager.LoadScene("FirstScene"); // ���񧹲��ɡA�[����firstscene
    }
}
