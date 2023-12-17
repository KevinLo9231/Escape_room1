
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
    public void Close(int index)
    {
        Panel[index].SetActive(false);
    }

    public void On(int index)
    {
        Panel[index].SetActive(true);
    }

    public void ImageChange()
    {
        oldImage.sprite = newImage;
    }
}
