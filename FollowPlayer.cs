using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject camera1;
    public GameObject camera2;
    private Vector3 offset1 = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 1.7f, 1);

    // Start is called before the first frame update
    void Start()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("m"))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }

        if (Input.GetKeyDown("n"))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }

        camera1.transform.position = player.transform.position + offset1;
        camera2.transform.position = player.transform.position + offset2;
    }
}
