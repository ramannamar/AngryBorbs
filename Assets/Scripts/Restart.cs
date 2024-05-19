using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class Restart : MonoBehaviour
    {
        public void RestartGame()
        {
            SceneManager.LoadScene("Game");
        }
    }
}
