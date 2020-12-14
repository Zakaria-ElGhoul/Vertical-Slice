using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CardDamage : MonoBehaviour
{
    [SerializeField] private EnemyHeroHealth h;
    [SerializeField] private Card d;
    [SerializeField] private Animation anim;
    [SerializeField] private AnimationClip animationClip;
    [SerializeField] private Vector3 StartingPoint;
    [SerializeField] private Vector3 EndPoint;
    [SerializeField] private float speed;


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
        DOTween.Kill("StartingPoint", true);
        DOTween.Kill("EndPoint", true);
    }

    void OnMouseDrag()
    {
        float disX = Input.mousePosition.x - posX;
        float disY = Input.mousePosition.y - posY;
        float disZ = Input.mousePosition.z - posZ;
        Vector3 lastPos = Camera.main.ScreenToWorldPoint(new Vector3(disX, disY, disZ));
        transform.position = new Vector3(lastPos.x, startPos.y, lastPos.z);
        DOTween.Kill("StartingPoint", true);
        DOTween.Kill("EndPoint", true);
    }

    void OnMouseUp()
    {
        anim.AddClip(animationClip, "PlacedCard");
        anim.Play("PlacedCard");
    }
    void OnMouseOver()
    {
        transform.DOLocalMove(EndPoint, speed).SetId("EndPoint");
    }

    void OnMouseExit()
    {
        transform.DOLocalMove(StartingPoint, speed).SetId("StartingPoint");
    }
}
