using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

    private Transform parentTransform = null;

    //wanneer je begint met draggen dan maakt ie zichzelf de parent
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentTransform = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
    }

    //wanneer je aan het draggen bent, dan transformt hij naar de positie van de muis
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    //wanneer je done bent met draggen dan verandert hij naar de hand
    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentTransform);
    }
}
