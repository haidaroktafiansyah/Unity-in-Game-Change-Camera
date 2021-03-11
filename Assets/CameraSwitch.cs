using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject[] cameras;

    public string[] shortcuts;

    public bool changeAudioListener = true;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < cameras.Length; i++)
            {
                if (Input.GetKeyDown(shortcuts[i])) SwitchCamera(i);
            }
        }
    }

    void SwitchCamera(int index)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            if (i != index)
            {
                cameras[i].GetComponent<Camera>().enabled = false;
                if (changeAudioListener)
                    cameras[i].GetComponent<AudioListener>().enabled = false;
            }
            else
            {
                cameras[i].GetComponent<Camera>().enabled = true;
                if (changeAudioListener)
                    cameras[i].GetComponent<AudioListener>().enabled = true;
            }
        }
    }
}
