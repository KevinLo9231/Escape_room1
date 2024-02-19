using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public void pipSound()
    {
        AudioManager.Instance.PlaySFX("mos");
    }


}
