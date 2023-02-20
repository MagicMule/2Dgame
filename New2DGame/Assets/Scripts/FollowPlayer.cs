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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (playerGO.transform.position.x, transform.position.y, transform.position.z);
    }
}
