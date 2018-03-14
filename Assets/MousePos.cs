using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePos : MonoBehaviour {

    Canvas parentCanvas;

	// Use this for initialization
	void Start () {
         parentCanvas = GetComponentInParent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 movePos;


        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            parentCanvas.transform as RectTransform,
            Input.mousePosition, parentCanvas.worldCamera,
            out movePos);

        Vector3 mousePos = parentCanvas.transform.TransformPoint(movePos);


        //Move the Object/Panel
        transform.position = mousePos;
	}
}
