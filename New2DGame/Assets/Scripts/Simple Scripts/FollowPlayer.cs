using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    /// <summary>
    /// Following the gameobjekt player, used for camra control
    /// </summary>
    public GameObject playerGO;
    public float offsetY = 0;
    public float offsetX = 0;

    public int cameraFocus = 2;

    void Start()
    {
        offsetY = playerGO.transform.position.y;
    }

    void Update()
    {
        SetCamraFocus(cameraFocus);
  
    }

    // Camra Fokus, 1 is fallaw x and y, 2 is follw x
    void SetCamraFocus(int cameraFocus)
    {
        switch (cameraFocus)
        {
            case 1:
                FollowThePlayerOnX();
                break;
            case 2:
                FollowThePlayerOnXAndY();
                break;
        }
    }
    // Camara follow Player On X, with Ofset
    void FollowThePlayerOnX()
    {
        // When the Camra canges back to playerOnX, cange the y value to follow the playerGO
        
        transform.position = new Vector3(playerGO.transform.position.x - offsetX, offsetY, transform.position.z);
    }
    // Camara Follows Player On X and Y
    void FollowThePlayerOnXAndY()
    {
        transform.position = new Vector3(playerGO.transform.position.x, playerGO.transform.position.y, transform.position.z);
    }
    public void UpdateY()
    {
        offsetY = playerGO.transform.position.y;
    }
}
