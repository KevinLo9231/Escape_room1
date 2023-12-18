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
    
    public void OnPointerEnter(PointerEventData eventData) // �����a�B��Botton�W�ABotton�N�|��j
    {       
        transform.localScale = originalScale * hoverScaleMultiplier;
    }

    public void OnPointerExit(PointerEventData eventData) // �������}��Botton�W�ABotton�N�|��^�쪬
    {       
        transform.localScale = originalScale;
    }
}
