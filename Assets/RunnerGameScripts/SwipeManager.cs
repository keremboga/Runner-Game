using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeManager : MonoBehaviour
{
    public bool tap, swipeLeft, swipeRight;
    public bool isDragging = false;
    public Vector2 startTouch, swipeDelta;


   
    void Start()
    {

    }

    
    private void Update()
    {

        swipeLeft = swipeRight = tap = false;

        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            tap = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            Reset();
        }
        if (Input.touches.Length != 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                tap = true;
                isDragging = true;
                startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDragging = false;
                Reset();
            }
        }
        swipeDelta = Vector2.zero;
        if (isDragging)
        {
            if (Input.touches.Length != 0)
            {
                swipeDelta = Input.touches[0].position - startTouch;
            }
            else if (Input.GetMouseButton(0))
            {
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
            }
        }
        if (swipeDelta.magnitude > 80)
        {
            float x = swipeDelta.x;
            if (x < 0)
            {
                swipeLeft = true;
            }
            else if (x > 0)
            {
                swipeRight = true;
            }
            Reset();
        }
    }
    private void Reset()
    {

        startTouch = swipeDelta = Vector2.zero;
        isDragging = false;
    }
}
