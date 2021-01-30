using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class RespondToKeyPresses : MonoBehaviour
{
    // Start is called before the first frame update
    #region PRIVATE MEMBERS
    cCur _curRotation;
    #endregion

    #region PUBLIC MEMBERS
    public TMP_Text _txtOrientation; // display orientation info onscreen
    #endregion
    void Start()
    {
        // track the current rotation of the SUDOKUBE, and assist with 
        // determining the orientation of the cube after it is rotated.
        _curRotation = new cCur(5, 6);  // the orientation of the cube is fully described by the Facing and Top Sides (5, 6)
        _txtOrientation.text = _curRotation.ToString();
    }

    // Update is called once per frame
    /**********************************************************************
     * Update()
     * Rotate the Camera around the SUDOKUBE so that each side is brought 
     * into view according to the direction key pressed.
     **********************************************************************/
    void Update()
    {
        bool movement = false;
        // Rotate the view so that the right side of the cube is brought facing the user.
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _curRotation.Move(eMovement.Right);
            movement = true;
        }
        // Rotate the view so that the left side of the cube is brought facing the user.
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _curRotation.Move(eMovement.Left);
            movement = true;
        }
        // rotate the view so that the top of the cube is brought facing the user
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _curRotation.Move(eMovement.Up);
            movement = true;
        }
        // rotate the view so that the bottom of the cube is brought facing the user.
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _curRotation.Move(eMovement.Down);
            movement = true;
        }
        if (movement)
            _txtOrientation.text = _curRotation.ToString();
    }
}
