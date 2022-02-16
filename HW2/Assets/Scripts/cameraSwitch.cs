using UnityEngine;

public class cameraSwitch : MonoBehaviour
{

    public GameObject cameraOne;
    public GameObject cameraTwo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            cameraOne.SetActive(true);
            cameraTwo.SetActive(false);
        }

        if (Input.GetKey("2"))
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(true);
        }
    }
}
