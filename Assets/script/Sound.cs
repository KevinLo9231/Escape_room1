using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] sounds; // 儲存多組聲音
    private bool hasPlayed = false; 

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(int index)
    {               
        if (index == 0) // index 0 存放咖啡喝水聲
        {            
            if(!hasPlayed) // 咖啡只容許喝一次
            {
                hasPlayed = true;
                audioSource.PlayOneShot(sounds[index]); // 根據索引播放對應的聲音
            }     
        }
        else if (index != 0)
        {
            audioSource.PlayOneShot(sounds[index]); // 根據索引播放對應的聲音
        }
    }
}
