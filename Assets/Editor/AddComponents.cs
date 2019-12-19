using UnityEngine;
using UnityEditor;
using UnityEngine.AI;

public class AddComponents : MonoBehaviour
{
    //world
    [MenuItem("Grandview TSA/Game Dev Tools/World/Add Moving Platform")]
    static void AddMovingPlat()
    {
        foreach(GameObject obj in Selection.gameObjects)
        {
            obj.AddComponent<MovingPlatformScript>();
        }
    }


    //entities

    [MenuItem("Grandview TSA/Game Dev Tools/Entities/AddStatsScript")]
    static void addStatsScript()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            obj.AddComponent<Stats>();
        }
    }

    [MenuItem("Grandview TSA/Game Dev Tools/Entities/Player/PlayerScript")]
    static void addPlayerScript()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            obj.AddComponent<CharacterController>();
            obj.AddComponent<PlayerControl>();
        }
    }

    [MenuItem("Grandview TSA/Game Dev Tools/Entities/AI/MakeEnemy")]
    static void MakeEnemy()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            obj.AddComponent<NavMeshAgent>();
        }
    }

    //Camera
    [MenuItem("Grandview TSA/Game Dev Tools/Camera/PlayerCamera")]
    static void addPlayerCamera()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            obj.AddComponent<PlayerCamera>();
        }
    }

    
}
