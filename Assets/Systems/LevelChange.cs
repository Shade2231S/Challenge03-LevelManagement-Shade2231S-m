using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public LevelManager levelManager;
    public GameObject leveltoactivate;
    public Transform spawnlocation;
    private void Start()
    {
       levelManager = Ervice.Instance.levelmanager;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            levelManager.levelchange();
        }
    }
}
