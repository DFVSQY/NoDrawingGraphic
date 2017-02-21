using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        AddClick(gameObject, (go) =>
        {
            Debug.Log("OnClick,go:" + go.name);
        });
    }

    private void AddClick(GameObject go, UnityAction<GameObject> onClick)
    {
        EventTrigger et = go.GetComponent<EventTrigger>();
        if(et == null)
        {
            et = go.AddComponent<EventTrigger>();
        }
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) =>
        {
            if(onClick != null) onClick(go);

        });
        et.triggers.Add(entry);
    }
}
