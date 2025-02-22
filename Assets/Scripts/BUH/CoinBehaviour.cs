using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour, ICollectable
{
    public int Value { get => 1; set => Value = value; }

    public CollectableType type => CollectableType.Money;
    public SpriteRenderer ourSprite;
    public Collider2D boundingBox;

    void Start()
    {
        ourSprite = GetComponent<SpriteRenderer>();
        boundingBox = GetComponent<Collider2D>();
    }
    public int Collect()
    {
        ourSprite.enabled = false; //When we collect something, it should disappear from the scene
        boundingBox.enabled = false;
        return Value;
    }
}