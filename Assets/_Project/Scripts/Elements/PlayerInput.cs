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
        var mousePosNormalized = mousePosX - 540;
        mousePosNormalized = mousePosNormalized * 4 / 1080;
        GetComponent<Player>().MovePlayer(mousePosNormalized);
        //BURADA MOUSEUN X EKSENÝNDEKÝ HAREKETÝNÝ OKUDUK
        //deðiþklenlerin ayný anda ismini deðiþtirmek için CTRL+R+R diyoruz
    }

    void DragStopped() 
    {

    }

}
