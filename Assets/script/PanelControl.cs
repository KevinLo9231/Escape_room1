
using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    //所有的面板控制物件
    public GameObject[] Panel;
    public Button[] OpenPanelButton;

    //咖啡轉換相片用
    public Image oldImage;
    public Sprite newImage;
    private bool hasPlayed = false;
    public void Close(int index)
    {
        Panel[index].SetActive(false);
    }

    public void On(int index)
    {
        Panel[index].SetActive(true);
    }

    public void CoffeeImageChange()
    {
        oldImage.sprite = newImage;
        if (!hasPlayed) // 咖啡只容許喝一次
        {
            hasPlayed = true;
            AudioManager.Instance.PlaySFX("drink");
        }
    }
}
