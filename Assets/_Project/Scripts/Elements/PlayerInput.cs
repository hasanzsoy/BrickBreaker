using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            DragStarted();
        }
        if (Input.GetMouseButton(0)) 
        {
            Dragged();
        }
        if (Input.GetMouseButtonUp(0)) 
        {
            DragStopped();
        }

    }

    void DragStarted() 
    {

    }

    void Dragged()
    {
        var mousePosX = Input.mousePosition.x;
        Debug.Log(mousePosX);
        //BURADA MOUSEUN X EKSENÝNDEKÝ HAREKETÝNÝ OKUDUK
    }

    void DragStopped() 
    {

    }

}
