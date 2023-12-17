using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] sounds; // 儲存多組聲音

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(int index)
    {        
        audioSource.PlayOneShot(sounds[index]); // 根據索引播放對應的聲音

    }
}
