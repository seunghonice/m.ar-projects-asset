using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;
public class Furniture : MonoBehaviour
{
    public Camera mainCamera;
    public Transform selectedIcon;

    private LeanDragTranslate _translate;
    private LeanPinchScale _pinch;
    private LeanTwistRotateAxis _axis;


    public bool IsSelected
    {
        get => selectedIcon.gameObject.activeSelf;
        set
        {
            _translate.enabled = _pinch.enabled = _axis.enabled = value;
            selectedIcon.gameObject.SetActive(value);
        }
    }

    void Start()
    {
        _translate = gameObject.AddComponent<LeanDragTranslate>(); // 이동
        _pinch = gameObject.AddComponent<LeanPinchScale>(); // 줌인 줌아웃        
        _axis = gameObject.AddComponent<LeanTwistRotateAxis>(); // 회전

        mainCamera = Camera.main;
    }

    void Update()
    {
        selectedIcon.transform.LookAt(mainCamera.transform); // billboard
    }
}
