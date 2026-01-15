using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject Level1;
    public GameObject Level2;
    private GameObject currentLeval;
    public void levelchange()
    {
        Level1.SetActive(false);
        Level2.SetActive(true);
    }
}
