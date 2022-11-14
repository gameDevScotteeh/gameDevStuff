using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairPointer : MonoBehaviour
{
    private Vector3 targetPostion;
    private RectTransform pointerRectTransform;
    [SerializeField]
    private Camera uiCamera;
    private void Awake()
    {
        targetPostion = new Vector3(-20,-16);
        pointerRectTransform = transform.Find("Pointer").GetComponent<RectTransform>();
    }

    private void Update()
    {
        Vector3 toPosition = targetPostion;
        Vector3 fromPosition = Camera.main.transform.position;
        fromPosition.z = 0;
        Vector3 dir = (toPosition - fromPosition).normalized;
        float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) % 360;
        pointerRectTransform.localEulerAngles = new Vector3(0,0,angle);

    }
}
