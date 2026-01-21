using UnityEngine;
[DefaultExecutionOrder(-100)]
public class Ervice : MonoBehaviour
{
    public static Ervice Instance { get; private set; }
    [Header("Manager Refrence")]
    public LevelManager levelmanager;
    public PlayerController playercontroller;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}
