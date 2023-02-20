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
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        FollowThePlayer();
    }
    void FollowThePlayer()
    {
        // Allwas Follow Player x position, and y pos is freely changablie
        transform.position = new Vector3(playerGO.transform.position.x - offsetX, offsetY, transform.position.z);
    }
}
