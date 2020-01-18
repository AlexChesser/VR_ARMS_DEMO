using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using bid = OVRSkeleton.BoneId;

public class FingerIK : MonoBehaviour
{
    private OVRSkeleton skeleton;
    private Animator animator;

    [SerializeField] HandTrackingFingerMap RH;
    [SerializeField] HandTrackingFingerMap LH;
    [SerializeField] OVRSkeleton RHS;
    [SerializeField] OVRSkeleton LHS;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void SetProperties(HTFinger d1, Transform d2) {
        //d1.position = d2.position;
        d1.transform.rotation = d2.rotation;
        d1.transform.Rotate(d1.offset);
    }

    private void UpdateHand(HandTrackingFingerMap h, OVRSkeleton s) {
        if (s == null || s.Bones.Count == 0) {
            return;
        }
        SetProperties(h.Hand_Index1, s.Bones[(int)bid.Hand_Index1].Transform);
        SetProperties(h.Hand_Index2, s.Bones[(int)bid.Hand_Index2].Transform);
        SetProperties(h.Hand_Index3, s.Bones[(int)bid.Hand_Index3].Transform);

        SetProperties(h.Hand_Middle1, s.Bones[(int)bid.Hand_Middle1].Transform);
        SetProperties(h.Hand_Middle2, s.Bones[(int)bid.Hand_Middle2].Transform);
        SetProperties(h.Hand_Middle3, s.Bones[(int)bid.Hand_Middle3].Transform);

        SetProperties(h.Hand_Ring1, s.Bones[(int)bid.Hand_Ring1].Transform);
        SetProperties(h.Hand_Ring2, s.Bones[(int)bid.Hand_Ring2].Transform);
        SetProperties(h.Hand_Ring3, s.Bones[(int)bid.Hand_Ring3].Transform);

        //SetProperties(h.Hand_Pinky0, s.Bones[(int)bid.Hand_Pinky0].Transform);
        SetProperties(h.Hand_Pinky1, s.Bones[(int)bid.Hand_Pinky1].Transform);
        SetProperties(h.Hand_Pinky2, s.Bones[(int)bid.Hand_Pinky2].Transform);
        SetProperties(h.Hand_Pinky3, s.Bones[(int)bid.Hand_Pinky3].Transform);

        //SetProperties(h.Hand_Thumb0, s.Bones[(int)bid.Hand_Thumb0].Transform);
        SetProperties(h.Hand_Thumb1, s.Bones[(int)bid.Hand_Thumb1].Transform);
        SetProperties(h.Hand_Thumb2, s.Bones[(int)bid.Hand_Thumb2].Transform);
        SetProperties(h.Hand_Thumb3, s.Bones[(int)bid.Hand_Thumb3].Transform);
    }


    public void PositionFingers() {
        UpdateHand(RH, RHS);
        UpdateHand(LH, LHS);
    }

    private void LateUpdate()
    {
        PositionFingers();
    }
}
