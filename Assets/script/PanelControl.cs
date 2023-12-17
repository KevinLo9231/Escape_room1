
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
