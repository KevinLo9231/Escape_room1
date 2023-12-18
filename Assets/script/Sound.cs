using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] sounds; // �x�s�h���n��
    private bool hasPlayed = false; 

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(int index)
    {               
        if (index == 0) // index 0 �s��@�سܤ��n
        {            
            if(!hasPlayed) // �@�إu�e�\�ܤ@��
            {
                hasPlayed = true;
                audioSource.PlayOneShot(sounds[index]); // �ھگ��޼���������n��
            }     
        }
        else if (index != 0)
        {
            audioSource.PlayOneShot(sounds[index]); // �ھگ��޼���������n��
        }
    }
}
