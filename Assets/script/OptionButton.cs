using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionButton : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Leave()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
    public void FirstScene()
    {
        SceneManager.LoadScene("FirstScene");
        AudioManager.Instance.PlayMusic("BGM");
    }

    public void GameScene2()
    {
        SceneManager.LoadScene("GameScene2");
    }
}
