using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject Level1;
    public GameObject Level2;
    private GameObject Player;
    private GameObject currentLevel;
    private void Start()
    {
        Player = Ervice.Instance.playercontroller.gameObject;
        Level1.SetActive(true);
        Level2.SetActive(false);
        currentLevel = Level1;
    }
    public void levelchange(Transform spawnpos,GameObject levelload)
    {
        currentLevel.SetActive(false);
        levelload.SetActive(true);
        currentLevel = levelload;
        Player.transform.position = spawnpos.position;
    }
}
