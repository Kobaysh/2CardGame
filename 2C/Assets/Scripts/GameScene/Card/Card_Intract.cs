using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
 
public class Card_Intract : MonoBehaviour {

    // static field
    public static bool isOnDrag = false;
    // public member

    // serialized field

    // private member
    private EventTrigger eventTrigger;
    private Button button;
    private UnityAction<BaseEventData> unityAction;
    private EventTrigger.Entry entryPointerEnter;
    private EventTrigger.Entry entryPointerClick;
    private EventTrigger.Entry entryBegineDrag;
    private EventTrigger.Entry entryDrag;
    private EventTrigger.Entry entryDrop;

    public void Awake()
    {
        
    }

    public void Start ()
    {
        button = GetComponent<Button>();

        if (!TryGetComponent(out EventTrigger et))
        {
            eventTrigger = gameObject.AddComponent<EventTrigger>();
        }
        else
        {
            eventTrigger = et;
        }

        EventAdd();
	}
	

    public void Update ()
    {
	
	}

    public void FixedUpdate() {
        
    }

    public void OnPointerEnter(BaseEventData data)
    {
        PointerEventData pointerEventData = (PointerEventData)data;
        
        Debug.Log(("OnPointerEneter"));
    }

    public void OnPointerClick(BaseEventData data)
    {
        Debug.Log(("OnPointerClick"));
    }

    public void OnBegineDrag(BaseEventData data)
    {
        isOnDrag = true;
        Debug.Log("BrgineDrag");
    }

    public void OnDraging(BaseEventData data)
    {
        Debug.Log("Draging");
        Vector2 mouse = Mouse.current.position.ReadValue();
        this.transform.position = mouse;
    }

    public void OnDrop(BaseEventData data)
    {
        Debug.Log("Drop");

    }

    private void EventAdd()
    {
        // ボタン内にマウスが入った時のイベントリスナー登録
        entryPointerEnter = new EventTrigger.Entry();
        entryPointerEnter.eventID = EventTriggerType.PointerEnter;
        entryPointerEnter.callback.AddListener(data => OnPointerEnter((BaseEventData)data));
        eventTrigger.triggers.Add(entryPointerEnter);

        // ボタンクリックのイベントリスナー登録
        unityAction = new UnityAction<BaseEventData>(OnPointerClick);
        unityAction += new UnityAction<BaseEventData>(OnBegineDrag);
        unityAction += new UnityAction<BaseEventData>(OnDraging);
        unityAction += new UnityAction<BaseEventData>(OnDrop);



        entryPointerClick = new EventTrigger.Entry();
        entryPointerClick.eventID = EventTriggerType.PointerClick;
        entryPointerClick.callback.AddListener(unityAction);
        eventTrigger.triggers.Add(entryPointerClick);


        entryBegineDrag = new EventTrigger.Entry();
        entryBegineDrag.eventID = EventTriggerType.BeginDrag;
        entryBegineDrag.callback.AddListener(unityAction);
        eventTrigger.triggers.Add(entryBegineDrag);

        entryDrag = new EventTrigger.Entry();
        entryDrag.eventID = EventTriggerType.Drag;
        entryDrag.callback.AddListener(unityAction);
        eventTrigger.triggers.Add(entryDrag);

        entryDrop = new EventTrigger.Entry();
        entryDrop.eventID = EventTriggerType.EndDrag;
        entryDrop.callback.AddListener(unityAction);
        eventTrigger.triggers.Add(entryDrop);
    }
}