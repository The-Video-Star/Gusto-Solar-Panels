using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Create menu of all scenes included in the build.
public class StartMenu : MonoBehaviour
{
    public OVROverlay overlay;
    public OVROverlay text;
    public OVRCameraRig vrRig;

    void Start()
    {
        DebugUIBuilder.instance.AddLabel("Gousto VR Solar Panels");

        /*        int n = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
                for (int i = 0; i < n; ++i)
                {

                        string path = UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(i);
                        var sceneIndex = i;
                        DebugUIBuilder.instance.AddButton(Path.GetFileNameWithoutExtension(path), () => LoadScene(sceneIndex));
                }*/
        string path = UnityEngine.SceneManagement.SceneUtility.GetScenePathByBuildIndex(1);
        DebugUIBuilder.instance.AddButton(Path.GetFileNameWithoutExtension(path), () => LoadScene(1));
        DebugUIBuilder.instance.Show();
    }

    void LoadScene(int idx)
    {
        DebugUIBuilder.instance.Hide();
        Debug.Log("Load scene: " + idx);
        UnityEngine.SceneManagement.SceneManager.LoadScene(idx);
    }
}
