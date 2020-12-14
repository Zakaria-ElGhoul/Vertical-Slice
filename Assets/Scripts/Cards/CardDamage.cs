using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDamage : MonoBehaviour
{
    [SerializeField] private EnemyHeroHealth h;
    [SerializeField] private Card d;
    [SerializeField] private Animation anim;
    [SerializeField] private AnimationClip[] animationClip;

    Vector3 dist;
    Vector3 startPos;
    float posX;
    float posZ;
    float posY;
    void OnMouseDown()
    {
        startPos = transform.position;
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
        posZ = Input.mousePosition.z - dist.z;
    }

    void OnMouseDrag()
    {
        float disX = Input.mousePosition.x - posX;
        float disY = Input.mousePosition.y - posY;
        float disZ = Input.mousePosition.z - posZ;
        Vector3 lastPos = Camera.main.ScreenToWorldPoint(new Vector3(disX, disY, disZ));
        transform.position = new Vector3(lastPos.x, startPos.y, lastPos.z);
    }
    void OnMouseUp()
    {
        anim.AddClip(animationClip[0], "PlacedCard");
        anim.Play("PlacedCard");
    }
    void OnMouseOver()
    {
        anim.AddClip(animationClip[1], "CardHover");
        anim.Play("CardHover");
    }
    void OnMouseExit()
    {
        anim.AddClip(animationClip[2], "CardHoverExit");
        anim.Play("CardHoverExit");
    }
}
