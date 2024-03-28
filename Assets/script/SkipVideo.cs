using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SkipVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer; // ���V�A�� Video Player

    public void skip()
    {
        videoPlayer.Stop(); // ����v������
        SceneManager.LoadScene("FirstScene"); // �[����firstscene
    }
}
