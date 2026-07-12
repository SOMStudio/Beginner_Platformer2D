using UnityEngine;
using UnityEngine.SceneManagement;

namespace _2D.Scripts
{
    public class Restarter : MonoBehaviour
    {
        public void StartFirstScene()
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
        
        public void StartScene(string nameScene)
        {
            SceneManager.LoadScene(nameScene);
        }
    }
}
