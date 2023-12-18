using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScaler : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    private Button button;
    private Vector3 originalScale;

    public float hoverScaleMultiplier = 1.2f;

    void Start()
    {
        button = GetComponent<Button>();
        originalScale = transform.localScale;//
    }
    
    public void OnPointerEnter(PointerEventData eventData) // 鼠標懸浮於Botton上，Botton將會放大
    {       
        transform.localScale = originalScale * hoverScaleMultiplier;
    }

    public void OnPointerExit(PointerEventData eventData) // 鼠標離開於Botton上，Botton將會返回原狀
    {       
        transform.localScale = originalScale;
    }
}
