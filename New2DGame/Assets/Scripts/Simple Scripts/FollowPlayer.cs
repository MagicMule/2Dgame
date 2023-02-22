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

    public bool FollowOnX = true;
    public bool FollowOnXAndY = false;
    public int cameraFocus = 2;

    void Start()
    {

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
                FollowOnXAndY = false;
                FollowThePlayerOnX();
                break;
            case 2:
                FollowOnX = false;
                FollowThePlayerOnXAndY();
                break;
        }
    }
    // Camara follow Player On X
    void FollowThePlayerOnX()
    {
        // Allwas Follow Player x position, and y pos is freely changablie
        transform.position = new Vector3(playerGO.transform.position.x - offsetX, offsetY, transform.position.z);
    }
    // Camara Follows Player On X and Y
    void FollowThePlayerOnXAndY()
    {
        transform.position = new Vector3(playerGO.transform.position.x, playerGO.transform.position.y, transform.position.z);
    }
}
