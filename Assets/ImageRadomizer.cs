using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageRadomizer : MonoBehaviour {

    Vector3[] positionArray;
    GameObject[] SpriteArray;

    void Start()
    {
        positionArray = new Vector3[]{
            mainCamera.ViewportToWorldPoint(new Vector3(0.2f,0.2f)) + (new Vector3(0,0,10)),
            mainCamera.ViewportToWorldPoint(new Vector3(0.2f,0.5f)) + (new Vector3(0,0,10)),
            mainCamera.ViewportToWorldPoint(new Vector3(0.4f,0.8f)) + (new Vector3(0,0,10)),
            mainCamera.ViewportToWorldPoint(new Vector3(0.8f,0.2f)) + (new Vector3(0,0,10)),
            mainCamera.ViewportToWorldPoint(new Vector3(0.8f,0.5f)) + (new Vector3(0,0,10)),
            mainCamera.ViewportToWorldPoint(new Vector3(0.9f,0.9f)) + (new Vector3(0,0,10))
        };

        SpriteArray = new GameObject[3];
        SpriteArray[0] = firstImage;
        SpriteArray[1] = secondImage;
        SpriteArray[2] = thirdImage;

        ActiveObject = thirdImage;

        //SetThinkingImage();
    }

    public GameObject firstImage;
    public GameObject secondImage;
    public GameObject thirdImage;

    public Camera mainCamera;

    GameObject ActiveObject;

    public void SetThinkingImage()
    {
        Debug.Log("Starting game.");
        //firstImage.transform.position = positionArray[1];// mainCamera.ViewportToWorldPoint(new Vector3(0.2f,0.2f)) + (new Vector3(0,0,10));
        GameObject NextObject;
        do
        {
            int index = Random.Range(0,3);
            NextObject = SpriteArray[index];
        } while (NextObject == ActiveObject);

        ActiveObject.transform.position = mainCamera.ViewportToWorldPoint(new Vector3(-1f, -1f));
        int Rindex = Random.Range(0, 6);
        NextObject.transform.position = positionArray[Rindex];
        ActiveObject = NextObject;
    }
	
}
