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

        //Vector3 targetPostitionScreenPoint = Camera.main.WorldToScreenPoint(targetPostion);
        //bool isOffScreen = targetPostitionScreenPoint.z <= 0 || targetPostitionScreenPoint.x >= Screen.width ||
        //        targetPostitionScreenPoint.y <= 0 || targetPostitionScreenPoint.y >= Screen.height;

        //if (isOffScreen)
        //{
        //    Vector3 cappedTargetScreenPosition = targetPostitionScreenPoint;
        //    if (cappedTargetScreenPosition.x <= 0) cappedTargetScreenPosition.x = 0f;
        //    if (cappedTargetScreenPosition.x >= Screen.width) cappedTargetScreenPosition.x = Screen.width;
        //    if (cappedTargetScreenPosition.y <= 0) cappedTargetScreenPosition.x = 0f;
        //    if (cappedTargetScreenPosition.y >= Screen.height) cappedTargetScreenPosition.x = Screen.height;

        //    Vector3 pointerWorldPosition = uiCamera.ScreenToWorldPoint(cappedTargetScreenPosition);
        //    pointerRectTransform.position = pointerWorldPosition;
        //    pointerRectTransform.localPosition = new Vector3(pointerRectTransform.localPosition.x, pointerRectTransform.localPosition.y,0f);
        //}

    }
}
