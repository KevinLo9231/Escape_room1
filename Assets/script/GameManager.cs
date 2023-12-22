using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public AudioSource bgmAudio; // ���ּҶ�
    public  Slider volumeslider; // ���q�ƽ�

    private static GameManager music; // �T�w�@�ӳ�z�ܼơA�����������ɤ��|�Q���s

    private void Awake()
    {
        if (music == null)
        {
            music = this;

            DontDestroyOnLoad(gameObject); // �n���i�H�d��U�@�ӳ����A���Q�R��
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update() //�`������BGM
    {
        if (bgmAudio != null)
        {
            bgmAudio.volume = volumeslider.value;
        }
    }
}

