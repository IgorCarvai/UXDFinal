using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageScript : MonoBehaviour {

   
    int ogsize;
    public Font main;
    public Font maker;
    public Font superMarioBros2;
    public Font superMarioU;
    static string byrgysuper = "<color=#0C9BD7>S</color><color=#F8CE0F>u</color><color=#E72828>p</color><color=#008000ff>e</color><color=#F8CE0F>r</color>";
    static string rgybgMario = "<color=#E72828>M</color><color=#008000ff>a</color><color=#F8CE0F>r</color><color=#0C9BD7>i</color><color=#008000ff>o</color>";
    static string bgyrgMario = "<color=#0C9BD7>M</color><color=#008000ff>a</color><color=#F8CE0F>r</color><color=#E72828>i</color><color=#008000ff>o</color>";
    string superMario = byrgysuper+" "+rgybgMario;

    public float dragSpeed = 2;
    private Vector3 dragOrigin;
    public Text name;
    public Text year;
    int start = 2955;
    int step = 352;
    
    void Start () {
        ogsize = name.fontSize;
	}
	
	void Update () {
        //this is used for sliding the UI images
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }
        //this is checkes the mario image's x position and uses that information
        //to change the text and year information shown
        //at first I did have them all be a certain amout apart however, I was unpleased with
        //the pixelation and scale of the images and had to make my own images side by side
        //this lead to having different spacing between them and thus I had to hard code the locations
        if (transform.localPosition.x  > 2955)
        {
            name.font = superMarioBros2;
            name.text = "<color=#E72828>Super Mario Bros.</color>";
            year.text = "1985";
        }
        else if (transform.localPosition.x < 2955 && transform.localPosition.x > 2653)
        {
            name.font = superMarioBros2;
            name.text = "<color=#E72828>Super Mario Bros. 2</color>";
            year.text = "1988";
        }
        else if (transform.localPosition.x < 2653 && transform.localPosition.x > 2312)
        {
            name.font = superMarioBros2;
            name.text = "<color=#E72828>Super Mario Land</color>";
            year.text = "1990";
        }
        else if (transform.localPosition.x < 2312 && transform.localPosition.x > 1975)
        {
            name.font = main;
            name.text = "<color=#E72828>S</color><color=#0C9BD7>u</color><color=#F8CE0F>p</color><color=#0C9BD7>e</color><color=#008000ff>r</color> <color=#008000ff>M</color><color=#0C9BD7>a</color><color=#F8CE0F>r</color><color=#E72828>i</color><color=#008000ff>o</color> <color=#F8CE0F>W</color><color=#0C9BD7>o</color><color=#008000ff>r</color><color=#E72828>l</color><color=#008000ff>d</color>";
            year.text = "1990";
        }
        else if (transform.localPosition.x < 1975 && transform.localPosition.x > 1688)
        {
            name.text = superMario + " Land 2";
            year.text = "1991";
        }
        else if (transform.localPosition.x < 1688 && transform.localPosition.x > 1278)
        {
            name.text = superMario + " Land 3";
            year.text = "1992";
        }
        else if (transform.localPosition.x < 1278 && transform.localPosition.x > 986)
        {
            name.text = "<color=#E72828>S</color><color=#0C9BD7>u</color><color=#F8CE0F>p</color><color=#0C9BD7>e</color><color=#008000ff>r</color> "+bgyrgMario+" <color=#E72828>64</color>";
            year.text = "1996";
        }
        else if (transform.localPosition.x < 986 && transform.localPosition.x > 658)
        {
            name.font = main;
            name.text = "<color=#00B0FFFF>Super Mario Sunshine</color>";
            year.text = "2002";
        }
        else if (transform.localPosition.x < 658 && transform.localPosition.x > 340)
        {
            name.font = superMarioU;
            name.text = "New <color=#ffffffff>Super Mario Bros.</color>";
            year.text = "2006";
        }
        else if (transform.localPosition.x < 340 && transform.localPosition.x > -7)
        {
            name.font = main;
            name.text = "<color=#ffffffff>Super</color> <color=#0C9BD7>M</color><color=#008000ff>a</color><color=#F8CE0F>r</color><color=#E72828>i</color><color=#008000ff>o</color> <color=#000080ff>Galaxy</color>";
            year.text = "2007";
        }
        else if (transform.localPosition.x < -7 && transform.localPosition.x > -336)
        {
            name.font = superMarioU;
            name.text = "<color=#ffffffff>New Super Mario Bros. Wii</color>";
            year.text = "2009";
        }
        else if (transform.localPosition.x < -336 && transform.localPosition.x > -719)
        {
            name.font = main;
            name.text = "<color=#ffffffff>Super</color> <color=#0C9BD7>M</color><color=#008000ff>a</color><color=#F8CE0F>r</color><color=#E72828>i</color><color=#008000ff>o</color> <color=#000080ff>Galaxy</color> <color=#E72828>2</color>";
            year.text = "2010";
        }
        else if (transform.localPosition.x < -719 && transform.localPosition.x > -1017)
        {
            name.font = main;
            name.text = superMario + " <color=#ffffffff>3D</color> <color=#0C9BD7>L</color><color=#008000ff>a</color><color=#E72828>n</color>d";
            year.text = "2011";
        }
        else if (transform.localPosition.x < -1017 && transform.localPosition.x > -1357)
        {
            name.font = superMarioBros2;
            name.fontSize = ogsize;
            name.text = "New<color=#ffffffff> Super Mario Bros. </color>2";
            year.text = "2012";
        }
        else if (transform.localPosition.x < -1357 && transform.localPosition.x > -1688)
        {
            name.font = superMarioU;
            name.fontSize = 70;
            name.text = "<color=#ffffffff>Super Mario Bros. </color><color=#08D8E5>U</color>";
            year.text = "2012";
        }
        else if (transform.localPosition.x < -1688 && transform.localPosition.x > -2010)
        {
            name.font = main;
            name.fontSize = ogsize;
            name.text = "<color=#ffffffff>Super</color> <color=#E72828>M</color><color=#008000ff>a</color><color=#F8CE0F>r</color><color=#0C9BD7>i</color><color=#ff00ffff>o</color> 3d World";
            year.text = "2013";
        }
        else if (transform.localPosition.x < -2010 && transform.localPosition.x > -2327)
        {
            name.font = maker;
            name.text = "<color=#000000ff>Super Mario Maker</color>";
            year.text = "2015";
        }
        else if (transform.localPosition.x < -2327)
        {
            name.font = main;
            name.text = "<color=#ffffffff>Super</color> <color=#E72828>M</color><color=#008000ff>a</color><color=#F8CE0F>r</color><color=#0C9BD7>i</color><color=#008000ff>o</color> <color=#08D8E5>Odyssey</color>";
            year.text = "2017";
        }

        //this is used for sliding the image
        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, 0, 0);
        if ((transform.localPosition.x > -2504 || move.x>0) && (transform.localPosition.x < 3130 || move.x <0))
        {
            transform.Translate(move, Space.World);
        }
    }
}
