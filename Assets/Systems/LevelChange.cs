using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public LevelManager levelmanager;
    private void Start()
    {
        levelmanager = Ervice.Instance.levalManager;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            levelmanager.levelchange();
        }
    }
}
