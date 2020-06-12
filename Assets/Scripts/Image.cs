using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
 
public class Image : MonoBehaviour {
 
    [SerializeField]
    private RawImage rawImage;
 
    
 
    private IEnumerator Start ()
    {
        print ("Downloading from the web");
        WWW www = new WWW("https://static-maps.yandex.ru/1.x/?ll=37.602714,55.589198&size=306,205&z=16&l=map&pt=37.603164,55.589256,pmwtm~37.64,55.76363,pmwtm99");
        yield return www;
        Texture2D texture = www.texture;
 
        rawImage.texture = texture;
 
        byte [] bytes = texture.EncodeToJPG ();
 
        File.WriteAllBytes(Application.persistentDataPath + "testTexture.jpg", bytes);
    }
}