using UnityEngine;
using HTC.UnityPlugin.Vive;
using HTC.UnityPlugin.VRModuleManagement;

public class ForViveInputUtility : MonoBehaviour
{
	void Start ()
    {
        
        var index = VRModule.GetRightControllerDeviceIndex();
        if (!VRModule.IsValidDeviceIndex(index)) return;

        var index1 = ViveRole.GetDeviceIndex(HandRole.RightHand);
        if (!ViveRole.IsValidIndex(0)) return;

        ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Trigger);

    }
	
	
	void Update () {
		
	}
}
