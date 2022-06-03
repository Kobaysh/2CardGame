using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card_Abstract : ScriptableObject
{
    // static field

    // public member

    // serialized field
    [SerializeField]
    protected string cardName;
    [SerializeField]
    protected int cost;
    [SerializeField]
    protected string cardText;
    [SerializeField]
    protected Card_Abstract upgratedCard = null;
    // private member

    public abstract void Awake();

    public abstract void Start();

     public abstract void Update();

    public abstract void Action();
}
