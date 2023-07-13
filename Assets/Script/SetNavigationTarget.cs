using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField]
    private Camera topDownCamera;
    [SerializeField]
    private GameObject navTargetObject;

    private NavMeshPath path;
    private LineRenderer line;

    private bool lineToggle = false;

    public GameObject NavTargetObject { get => navTargetObject; set => navTargetObject = value; }
    public NavMeshPath Path { get => path; set => path = value; }

    private void Start()
    {
        Path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
    }

    private void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            lineToggle = !lineToggle;
        }
        if (lineToggle)
        {
            NavMesh.CalculatePath(transform.position, NavTargetObject.transform.position, NavMesh.AllAreas, Path);
            line.positionCount = path.corners.Length;
            line.SetPositions(Path.corners);
            line.enabled = true;
        }
    }
}
