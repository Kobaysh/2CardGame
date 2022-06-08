using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Card
{
    public abstract class Card_Abstract : ScriptableObject
    {
        // static field

        // public member
        public enum Card_Type
        {
            Attack,
            Skill,
            Power
        }

        // serialized field
        [SerializeField]
        protected string cardName;
        [SerializeField]
        protected int cost;
        [SerializeField]
        protected Card_Type cardType;
        [SerializeField]
        protected string cardText;
        [SerializeField]
        protected Card_Abstract upgratedCard = null;
        // private member



        public abstract void Action();
    }
}