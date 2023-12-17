using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] sounds; // �x�s�h���n��

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(int index)
    {        
        audioSource.PlayOneShot(sounds[index]); // �ھگ��޼���������n��

    }
}
