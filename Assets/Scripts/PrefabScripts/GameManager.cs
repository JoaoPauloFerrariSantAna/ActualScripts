using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager mStance;
    public static GameManager gInstance => mStance;

    [SerializeField]
    private Player mPlayer;

    void Start()
    {
        mStance = this;
    }

    void Update()
    {
    }
}
