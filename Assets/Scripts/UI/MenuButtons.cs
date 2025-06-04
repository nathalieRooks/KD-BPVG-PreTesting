using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitMenu()
    {
        Application.Quit();
    }

    public void MenuButton()
    {
        int menuIndex = 0;
        SceneManager.LoadScene(menuIndex, LoadSceneMode.Single);
    }
}
