
using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    //�Ҧ������O�����
    public GameObject[] Panel;
    public Button[] OpenPanelButton;

    //�@���ഫ�ۤ���
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
        if (!hasPlayed) // �@�إu�e�\�ܤ@��
        {
            hasPlayed = true;
            AudioManager.Instance.PlaySFX("drink");
        }
    }
}
