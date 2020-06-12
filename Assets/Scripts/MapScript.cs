using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapScript : MonoBehaviour
{
    string url = "";
	
	public float lat = 24.917828f;
	public float lon = 67.097096f;
	LocationInfo li;
	
	
	private bool loadingMap = false;
	
	private IEnumerator mapCoroutine;
	
	IEnumerator GetGoogleMap(float lat, float lon)
	{
		url = "https://static-maps.yandex.ru/1.x/?ll=37.602714,55.589198&size=306,205&z=16&l=map&pt=37.602714,55.589198,pmwtm~37.64,55.76363,pmwtm99";
		
		/*url = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + 
		 "," + lon + "&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight
		+ "&key=AIzaSyDP_yQ0qbykYCwnhS1C8JPKk8Ii9kcrbio";*/
		loadingMap = true;
		WWW www = new WWW(url);
		yield return www;
		loadingMap = false;
		
		gameObject.GetComponent<RawImage>().texture = www.texture;
		StopCoroutine (mapCoroutine);
	}
	
	void Start()
	{
		mapCoroutine = GetGoogleMap (lat, lon);
		StartCoroutine (mapCoroutine);
		
	}
			
	
}
