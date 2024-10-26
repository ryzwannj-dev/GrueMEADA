using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    private int activeCameraIndex = 0;

    void Start()
    {
        // Ensure only one AudioListener is active
        SetActiveCamera(0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            activeCameraIndex = (activeCameraIndex + 1) % 3;
            SetActiveCamera(activeCameraIndex);
        }
    }

    void SetActiveCamera(int cameraIndex)
    {
        // Disable all cameras and their AudioListeners, then activate the selected one
        camera1.gameObject.SetActive(cameraIndex == 0);
        camera1.GetComponent<AudioListener>().enabled = (cameraIndex == 0);

        camera2.gameObject.SetActive(cameraIndex == 1);
        camera2.GetComponent<AudioListener>().enabled = (cameraIndex == 1);

        camera3.gameObject.SetActive(cameraIndex == 2);
        camera3.GetComponent<AudioListener>().enabled = (cameraIndex == 2);
    }
}
