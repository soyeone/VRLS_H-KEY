using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour {

    private SteamVR_TrackedObject trackedObject;

    public GameObject laserPrefab;
    public Transform cameraRigTransform;
    public GameObject teleportReticlePrefab;
    public Transform headTreansform;
    public Vector3 teleportReticleOffset;
    public LayerMask teleportMask;
    public LayerMask UIMake;

    private bool shoulTeleport;
    private GameObject reticle;
    private Transform teleportReticleTransform;
    private GameObject laser;
    private Transform laserTransform;
    private Vector3 hitPoint;
    private bool isclicked=false;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObject.index); }
    }

    private void Awake()
    {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    private void ShowLaser(RaycastHit hit)
    {
        laser.SetActive(true);
        laserTransform.position = Vector3.Lerp(trackedObject.transform.position, hitPoint, 0.5f);
        laserTransform.LookAt(hitPoint);

        laserTransform.localScale = new Vector3(laserTransform.localScale.x,
            laserTransform.localScale.y, hit.distance);
    }

    private void Teleport()
    {
        shoulTeleport = false;
        reticle.SetActive(false);
        Vector3 difference = cameraRigTransform.position - headTreansform.position;
        difference.y = 0;
        cameraRigTransform.position = hitPoint + difference;
    }

    private void InputUI(RaycastHit hit)
    {
        if (!isclicked)
        {
            isclicked = true;
            laser.SetActive(true);
            laserTransform.position = Vector3.Lerp(trackedObject.transform.position, hitPoint, 0.5f);
            laserTransform.LookAt(hitPoint);

            laserTransform.localScale = new Vector3(laserTransform.localScale.x,
            laserTransform.localScale.y, hit.distance);
        }
        else
            isclicked = false;

    }
    // Use this for initialization
    void Start () {

        laser = Instantiate(laserPrefab);
        laserTransform = laser.transform;

        reticle = Instantiate(teleportReticlePrefab);
        teleportReticleTransform = reticle.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Controller.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            RaycastHit hit;

            if (Physics.Raycast(trackedObject.transform.position, transform.forward, out hit, 100, teleportMask))
            {
                hitPoint = hit.point;
                ShowLaser(hit);

                reticle.SetActive(true);
                teleportReticleTransform.position = hitPoint + teleportReticleOffset;
                shoulTeleport = true;
            }

            if (Physics.Raycast(trackedObject.transform.position, transform.forward, out hit, 100, UIMake))
            {
                hitPoint = hit.point;
                InputUI(hit);

            }
        }
        else {
            laser.SetActive(false);
            reticle.SetActive(false);
        }

        if (Controller.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad) && shoulTeleport)
        {
            Teleport();
        }
        
	}
}
