using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballShooter : MonoBehaviour
{
    [SerializeField] private GameObject playerFireball;
    private GameObject _fireball;
    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          
            // FOR SPHERES
            /*            
                        Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
                        Ray ray = _camera.ScreenPointToRay(point);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            GameObject hitObject = hit.transform.gameObject;
                            ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                            if (target != null)
                            {
                                Debug.Log("Hit " + hit.point);
                                target.ReactToHit();
                            }
                            else
                            {
                                StartCoroutine(ShpereIndicator(hit.point));
                            }
                        }*/


            StartCoroutine(throwFireball());
        }
    }
    private void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }
    /*    private IEnumerator ShpereIndicator(Vector3 pos)
        {
            GameObject shpere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            shpere.transform.position = pos;
            yield return new WaitForSeconds(2);
            Destroy(shpere);
        }*/

    private IEnumerator throwFireball()
    {
        yield return new WaitForSeconds(0.01f);
        _fireball = Instantiate(playerFireball) as GameObject;
        _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
        _fireball.transform.rotation = transform.rotation;
        //Destroy(shpere);
    }
}
