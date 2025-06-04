using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    
    public static Lives Instance;
    public TextMeshProUGUI text;
    public int lives = 3;
    public GameObject MenuButton;

    // start bij begin
    private void Start()
    {
        // Zorgt dat er maar 1 is
        if (Instance == null)
        { Instance = this; }
    }

    // Haalt 1 leven van de levens
    public void punten(int liveCount)
    {
        lives -= liveCount;
        text.text =  lives.ToString() + "X";

        if (lives <= 0)
        {
            MenuButton.gameObject.SetActive(true);
        }
    }
    
    // Geeft lives terug
    public int LoseLive()
    {
        return lives;
    }
}
