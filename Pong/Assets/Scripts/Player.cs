using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera playerCam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
            Application.Quit(); 
        if(Input.touchCount != 1){
            return;
        }
        var ray = playerCam.ScreenPointToRay(Input.touches[0].position);
        var hitInfo = new RaycastHit();
        if(Physics.Raycast(ray, out hitInfo)){
            if (hitInfo.transform.name != "Bound South"){
                return;
            }
            var x = hitInfo.point.x;
            var newPos = transform.position;
            newPos.x = x;
            transform.position = newPos;
        }

        
    }
}
