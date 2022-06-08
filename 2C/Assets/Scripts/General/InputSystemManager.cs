using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using Card;

namespace Inuput {
    public class InputSystemManager : MonoBehaviour {

        // static field

        // public member

        // serialized field

        // private member
        private Card_Object havingCard;
        [SerializeField]
        private Vector2 mousePos;

        public void Awake() {

        }

        public void Start() {

        }


        public void Update() {

        }

        public void FixedUpdate() {

        }

        public void OnMouseDrag()
        {

         //   havingCard.transform.position =  Input.mousePosition;
        }

        public void OnMousePosition(InputAction.CallbackContext _call)
        {
            mousePos = _call.ReadValue<Vector2>();
        }
        public void OnClick(InputAction.CallbackContext _call)
        {
            
        }
        public bool isInRectMouse(Rect rect)
        {
            return rect.Contains(Input.mousePosition);
         //   return false;
        }
    }
}