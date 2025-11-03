using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // The name of the VR scene as it appears in Build Settings
    [SerializeField] private string vrSceneName = "Alvin VR Room";

    // Called from a UI button or event trigger
    public void LoadVRScene()
    {
        // Optional: fade out, play sound, etc. here
        SceneManager.LoadScene(Alvin VR Room);
    }

    
}
